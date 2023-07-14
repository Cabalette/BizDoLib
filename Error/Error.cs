namespace BizDoLib
{
    //     export namespace Errors{
    public enum HttpErrors
    {
        EMAIL_EXIST,
        BAD_PASSWORD,
        WRONG_PASSWORD,
        BAD_EMAIL,
        WRONG_EMAIL,
        LIMIT_OF_ORGANIZATIONS
    }
    //   export const enum HttpErrors {
    //       EMAIL_EXIST,
    //       BAD_PASSWORD,
    //       WRONG_PASSWORD,
    //       BAD_EMAIL,
    //       WRONG_EMAIL,
    //       LIMIT_OF_ORGANIZATIONS
    //   }
    public enum ServerErrors
    {
        AUTH_FAILED = 200,
        REGISTRATION_FAILED,
        UPDATE_FAILED,
        LOGOUT_FAILED,
        FAILED_TO_GET_USER,
        EMAIL_EXISTENSE_CHECK_FAILED,
        GET_SESSION_FAILED,
        CREATION_FAILED,
        GET_FAILED,
        DELETE_FAILED
    }
    //   export const enum ServerErrors {
    //     AUTH_FAILED = 200,
    //     REGISTRATION_FAILED,
    //     UPDATE_FAILED,
    //     LOGOUT_FAILED,
    //     FAILED_TO_GET_USER,
    //     EMAIL_EXISTENSE_CHECK_FAILED,
    //     GET_SESSION_FAILED,
    //     CREATION_FAILED,
    //     GET_FAILED,
    //     DELETE_FAILED
    //   }
    // }
}