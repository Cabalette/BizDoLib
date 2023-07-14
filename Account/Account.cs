//import { IOrganization } from "../organization/organization";
//import { ITypeWithImage } from "../other/other";
namespace BizDoLib
{
    public class Account
    {
        public interface IAccountEmail
        {
            public string Email { get; }
        }
        //export declare interface IAccountEmail
        //{
        //    email: string;
        //}

        public interface IAccountPassword
        {
            public string Password { get; }
        }
        //export declare interface IAccountPassword
        //{
        //    password: string;
        //}

        public interface AccountAuthenticationType : IAccountEmail, IAccountPassword { }
        //export declare type AccountAuthenticationType = IAccountEmail & IAccountPassword;

        public interface IAccount : IAccountEmail, ITypeWithImage
        {
            public string Uid { get; }
            public string FirstName { get; }
            public string LastName { get; }
            public string MiddleName { get; }
            public string Phone { get; }
            public IOrganization[]? Organizations { get; }
        }
        //export declare interface IAccount extends ReturnType<() => IAccountEmail & ITypeWithImage > {
        //uid: string;
        //firstName: string;
        //lastName: string;
        //middleName: string;
        //phone: string;
        //    organizations ?: IOrganization[];
        //}

        public interface AccountRegistrationType : IAccountEmail, IAccountPassword
        {
            public string FirstName { get; }
            public string LastName { get; }
        }
        //export declare type AccountRegistrationType = Pick<IAccount, "firstName" | "lastName"> & IAccountPassword & IAccountEmail;

        public interface AccountUpdatingType
        {
            public string Uid { get; }
            public string FirstName { get; }
            public string LastName { get; }
            public string MiddleName { get; }
            public string Phone { get; }
        }
        //export declare type AccountUpdatingType = Omit<IAccount, 'organizations' | 'image' | 'email'>;

        public interface IAccountRedisRecord
        {
            public string[] Tokens { get; }
            public Organization[] Organizations { get; }
            public class Organization
            {
                public int Id;
                public string Name;
                public int[] Permissions;
            }
        }
        //export declare interface IAccountRedisRecord
        //{
        //    tokens: string[];
        //    organizations: {
        //        id: number;
        //        name: string;
        //        permissions: number[];
        //    }
        //[] ;
        //}

    }
}