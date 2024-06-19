using System.Diagnostics.CodeAnalysis;
using System.Text;
using AdsterraTestTask;

public static class Program
{
    public static void Main()
    {
        var managers = Manager.GetManagers();
        var statuses = Status.GetStatuses();
        var chats = Chat.GetChats();

    }
}