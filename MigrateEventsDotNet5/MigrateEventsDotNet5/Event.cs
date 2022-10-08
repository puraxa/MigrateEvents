namespace MigrateEventsDotNet5
{
    public enum Event
    {
        CSAActivated = 1,
        TitleChanged = 2,
        ClassificationChanged = 3,
        CSADeactivated = 4,
        CSAReactivated = 5,
        CSAConfirmed = 6,
        CSAResposibilitiesConfirmed = 7,
        CSAResponsibilitiesNotConfirmed = 8,
        CSAReportsConfirmed = 9,
        CSAReportsNotConfirmed = 10,
        TrainingAssigned = 11,
        TrainingCanceled = 12,
        TrainingCompleted = 13,
        TrainingStarted = 14,
        TrainingAndQuizCompleted = 15
    }
}