// import { ClientProxy } from "@nestjs/microservices";
// import { HttpExceptionAdapter } from "../errors/HttpException";
// import { lastValueFrom } from "rxjs";
namespace BizDoLib
{
    public class Service
    {
        protected ClientProxy Client { get; set; }
        public Service(params object[] args)
        {
            foreach (var cl in args)
            {
                if (cl is ClientProxy)
                {
                    this.Client = cl;
                }
            }
        }

        // export class Service {
        //     protected client: ClientProxy | undefined;
        //     constructor(...args: any[]){
        //         for(const cl of args)
        //         if(cl instanceof ClientProxy)
        //         this.client = cl;
        //     }

        protected async Task<T> ClientSend<T>(string topic, object data, string errMessage, int errStatus)
        {
            if (this.Client != null)
            {
                try
                {
                    return await this.Client.SendAsync<T>(topic, data);
                }
                catch
                {
                    throw new HttpExceptionAdapter(errMessage, errStatus);
                }
            }
            throw new Exception("Client is null");
        }
    }
    это перевод сайта
    //     protected async clientSend<T>( topic: string, data: unknown, errMessage: string|number, errStatus: number ): Promise<T> {
    //         if(this.client)
    //         return await lastValueFrom<T>(this.client.send(topic, data)).catch(()=>{throw new HttpExceptionAdapter(errMessage, errStatus)});
    //         throw "Client is undefined!"
    //     }
}