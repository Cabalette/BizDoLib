// import { ISearch } from "../sequelize/sequelize";
namespace BizDoLib
{
    public interface IRolePermission
    {
        public int Id { get; }
        public int RolId { get; }
        public int PermissionId { get; }
    }
    // export interface IRolePermission {
    //     id: number;
    //     roleId: number;
    //     permissionId: number;
    // }

    public interface IRole
    {
        public int Id { get; }
        public string Name { get; }
        public int OrganizationId { get; }
        public int HigherRoleIdId { get; }
    }
    // export interface IRole {
    //     id: number;
    //     name: string;
    //     organizationId: number;
    //     higherRoleId: number;
    // }

    public interface CreateRoleType
    {
        public string Name { get; }
        public int OrganizationId { get; }
        public int[] Permissions { get; }
    }
    // export type CreateRoleType = Pick<IRole, 'name'|'organizationId'>&{permissions: number[]};

    public interface UpdateRoleType
    {
        public int Id { get; }
        public string Name { get; }
        public int HigherRoleIdId { get; }
    }
    // export type UpdateRoleType = Omit<IRole, 'organizationId'>;

    public interface UpdateRolePermissionsType
    {
        public int Id { get; }
        public int[] Permissions { get; }
    }
    // export type UpdateRolePermissionsType = Pick<IRole, 'id'>&{permissions: number[]};


    public interface GetRolesType : ISearch
    {
        public int OrganizationId { get; }
    }
    // export type GetRolesType = {organizationId: number}&Partial<ISearch>;
}