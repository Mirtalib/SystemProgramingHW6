using System.Threading;

namespace SystemProgramingHW6;

public partial class Form1 : Form
{
    int countThread = 0;
    List<Thread> Threads= new List<Thread>();

    Semaphore semaphore = new Semaphore(4, 4, "SEMAPHORE");

    public Form1()
    {
        InitializeComponent();

        domainUpDown1.Items.Capacity = int.MaxValue;
        domainUpDown1.Text = "1";
    }

    private void button1_Click(object sender, EventArgs e)
    {


        Thread thread = new Thread(SomeMethod);
        Threads.Add(thread);

        thread.Name = $"Thread {++countThread}";


        listBoxCreateThreads.Items.Add(thread.Name);
    }




    void SomeMethod(object? state)
    {
        var semaphore = state as Semaphore;

        if (semaphore is null)
            return;

        bool isFinish = false;

        string? name = Thread.CurrentThread.Name;
        while (!isFinish)
        {
            if (semaphore.WaitOne(2000))
            {
                try
                {
                    listBoxWaitingThreads.Items.Remove(name!);

                    listBoxWorkingThreads.Items.Add(name!);
                    Thread.Sleep(6000);
                }
                finally
                {
                    isFinish = true;
                    listBoxWorkingThreads.Items.Remove(name!);
                    semaphore.Release();
                }
            }
        }
    }

    private void listBoxCreateThreads_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxCreateThreads.SelectedItem is null)
            return;

        listBoxWaitingThreads.Items.Add(listBoxCreateThreads.SelectedItem);

        foreach (var item in Threads)
        {
            if (item.Name == listBoxCreateThreads.SelectedItem)
            {
                listBoxCreateThreads.Items.Remove(listBoxCreateThreads.SelectedItem);
                item.Start(semaphore);
            }
        }

    }
}