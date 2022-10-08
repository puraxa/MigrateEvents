// See https://aka.ms/new-console-template for more information


using MigrateEvents;
using MigrateEvents.Models;

Console.WriteLine("Hello, World!");


var db = new sqldbcleryedgelocalContext();

var history = db.CleryCsauserHistories.ToList();
foreach (var his in history)
{
    switch (his.ActionName)
    {
        case "History: Designated as a CSA":
            his.ActionId = (int) Event.CSAActivated;
            break;
        case "History: Title updated":
            his.ActionId = (int) Event.TitleChanged;
            break;
        case "History: Classification updated":
            his.ActionId = (int) Event.ClassificationChanged;
            break;
        case "History: Deactivated as a CSA":
            his.ActionId = (int) Event.CSADeactivated;
            break;
        case "History: Reactivated as a CSA":
            his.ActionId = (int) Event.CSAReactivated;
            break;
        case "History: Responsibilities confirmed":
            his.ActionId = (int) Event.CSAResposibilitiesConfirmed;
            break;
        case "History: Reports confirmed":
            his.ActionId = (int) Event.CSAReportsConfirmed;
            break;
    }

    if (!string.IsNullOrEmpty(his.ActionName) && his.ActionName.StartsWith("Training"))
    {
        var trainingName = his.ActionName.Split("\"")[1];
        if (his.ActionName.Contains("Training: Registered for"))
        {
            his.ActionId = (int) Event.TrainingAssigned;
        }

        if (his.ActionName.Contains("registration canceled"))
        {
            his.ActionId = (int) Event.TrainingCanceled;
        }
        
        if (his.ActionName.Contains("course completed"))
        {
            his.ActionId = (int) Event.TrainingCompleted;
        }

        if (his.ActionName.Contains("started"))
        {
            his.ActionId = (int) Event.TrainingStarted;
        }

        if (his.ActionName.Contains("course and quiz completed"))
        {
            his.ActionId = (int) Event.TrainingAndQuizCompleted;
        }

        his.TrainingId = db.TrainingCourses.FirstOrDefault(x => x.Name == trainingName)?.CourseId;
    }
    Console.WriteLine(his.HistoryId + " completed");
}
db.SaveChanges();
Console.WriteLine("Done");
