// import { ISearch } from "../sequelize/sequelize";
namespace BizDoLib
{
    public interface IVacancy
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }
        public bool Confirmed { get; }
    }
    // export interface IVacancy {
    //     id: number;
    //     name: string;
    //     email: string;
    //     phone: string;
    //     confirmed: boolean;
    // }

    public interface IVacancyGroup
    {
        public int Id { get; }
        public int VacancyId { get; }
        public int GroupId { get; }
    }
    // export interface IVacancyGroup{
    //     id: number;
    //     vacancyId: number;
    //     groupId: number;
    // }

    public interface CreateVacanciesType
    {
        public int RoleId { get; }
        public VacancyLike[] Vacancies { get; }
        interface VacancyLike
        {
            public string Name { get; }
            public string Email { get; }
            public string Phone { get; }
        }
    }
    // export type CreateVacanciesType = {roleId: number}&{vacancies: Omit<IVacancy, 'id'|'confirmed'>[]};

    public interface UpdateVacancyType
    {
        ты написал "RoleId", но его нету в IVacancy
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }
    }
    // export type UpdateVacancyType = Omit<Partial<IVacancy>, 'roleId'|'confirmed'>;

    public interface GetVacanciesType : ISearch
    {
        public int RoleId { get; }
    }
    // export type GetVacanciesType = { roleId: number }&Partial<ISearch>;
}