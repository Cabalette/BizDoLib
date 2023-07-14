//import { HttpException, HttpExceptionOptions } from "@nestjs/common";
namespace BizDoLib
{
    public class HttpExceptionAdapter : HttpException
    {
        public HttpExceptionAdapter(object message, int status, HttpExceptionOptions options = null)
        : base((message is string) ? (string)message : message.ToString(), status, options)
        {
        }
    }
    это перевод сайта
    // export class HttpExceptionAdapter extends HttpException {
    //     constructor(message: number|string, status: number, options?: HttpExceptionOptions){
    //         super((typeof message) == 'string'?message as string:message.toString(), status, options)
    //         return this;
    //     }
}