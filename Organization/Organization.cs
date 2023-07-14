// import { ITypeWithImage } from "../other/other";
// import { IRole } from "../role/role";
// import { IVacancy } from "../vacancy/vacancy"
namespace BizDoLib
{
    public interface IOrganization : ITypeWithImage
    {
        public int Id { get; }
        public string Name { get; }
        public IRole?[] Roles { get; }
        public IVacancy?[] Vacancies { get; }
    }
    // export interface IOrganization extends ITypeWithImage {
    //     id: number;
    //     name: string;
    //     roles?: IRole[]
    //     vacancies?: IVacancy[]
    //   }
    public interface IOrganizationCreate
    {
        public string Name { get; }
        public RoleNoId Role { get; }
        public VacancyNoId Vacancy { get; }
        class RoleNoId
        {
            string Name;
            int OrganizationId;
            int HigherRoleId;
        }
        class VacancyNoId
        {
            string Name;
            string Email;
            string Phone;
            bool Confirmed;
        }
    }
    // export  interface IOrganizationCreate{
    //     name: string;
    //     role: Omit<IRole, 'id'>;
    //     vacancy: Omit<IVacancy, 'id'>;
    //     userUid: string;
    // }
    public interface IGroup
    {
        public int Id { get; }
        public string Name { get; }
        public int OrganizationId { get; }
        public int HigherRoleId { get; }
    }
    // export interface IGroup {
    //   id: number,
    //   name: string;
    //   organizationId: number;
    //   higherGroupId: number;
    // }
}

