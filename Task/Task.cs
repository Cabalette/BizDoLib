namespace BizDoLib
{
    public interface ITask
    {
        public int Id { get; }
        public string Title { get; }
        public string Descriprion { get; }
        public int AssignedToVacancyId { get; }
        public int AssignedByVacancyId { get; }
        public int AssignedToGroupId { get; }
        public int StatusId { get; }
        public int HigherTaskId { get; }
        public DateTime FromDate { get; }
        public DateTime ToDate { get; }
        public bool IsBlocking { get; }
        public bool IsDelegated { get; }
    }
    // export interface ITask {
    //     id: number;
    //     title: string;
    //     descriprion: string;
    //     assignedToVacancyId: number;
    //     assignedByVacancyId: number;
    //     assignedToGroupId: number;
    //     statusId: number;
    //     higherTaskId: number;
    //     fromDate: Date;
    //     toDate: Date;
    //     isBlocking: boolean;
    //     isDelegated: boolean;
    // }

    public interface IDailyTaskGroup
    {
        public int Id { get; }
        public string Name { get; }
        public int VacancyId { get; }
    }
    // export interface IDailyTaskGroup {
    //     id: number;
    //     name: string;
    //     vacancyId: number;
    // }

    public interface IDailyTaskHistory
    {
        public int Id { get; }
        public string ImageUrl { get; }
        public string IsDone { get; }
        public int DailyTaskId { get; }
    }
    // export interface IDailyTaskHistory {
    //     id: number;
    //     imageUrl: string;
    //     isDone: string;
    //     dailyTaskId: number;
    // }

    public interface IDailyTask
    {
        public int Id { get; }
        public string Title { get; }
        public int DailyTaskGroupId { get; }
    }
    // export interface IDailyTask {
    //     id: number;
    //     title: string;
    //     dailyTaskGroupId: number;
    // }
}