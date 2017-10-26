using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace HackIB.Controllers.Class
{
    public class Watson
    {

        public static Dialogo Conversa(string texto)
        {

            HttpClient clienteWeb = new HttpClient();
            var content = new StringContent("{\"input\": {\"text\": \"" + texto + "\"}}", Encoding.UTF8, "application/json");

            clienteWeb.DefaultRequestHeaders.TryAddWithoutValidation("Content-type", "application/json");
            clienteWeb.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Basic N2MxZTM2ZDctOGUxOS00MDkxLWE3OGItYTZkY2Y4NjljYTI0OkNyVjVqeWpMQjgzVQ==");
            Task<HttpResponseMessage> post = clienteWeb.PostAsync("https://gateway.watsonplatform.net/conversation/api/v1/workspaces/"+Constantes.workspaceId+"/message?version="+Constantes.versionDate, content);
            post.Wait();
            Task<string> contents = post.Result.Content.ReadAsStringAsync();
            contents.Wait();
            return new JavaScriptSerializer().Deserialize<Dialogo>(contents.Result);
        }

    }
    public class Intent
    {
        public string intent { get; set; }
        public double confidence { get; set; }
    }

    public class Input
    {
        public string text { get; set; }
    }

    public class Output
    {
        public List<string> text { get; set; }
        public List<string> nodes_visited { get; set; }
        public List<object> log_messages { get; set; }
    }

    public class DialogStack
    {
        public string dialog_node { get; set; }
    }

    public class NodeOutputMap
    {
        public List<int> node_1_1508153946939 { get; set; }
    }

    public class System
    {
        public List<DialogStack> dialog_stack { get; set; }
        public int dialog_turn_counter { get; set; }
        public int dialog_request_counter { get; set; }
        public NodeOutputMap _node_output_map { get; set; }
        public bool branch_exited { get; set; }
        public string branch_exited_reason { get; set; }
    }

    public class Context
    {
        public string conversation_id { get; set; }
        public System system { get; set; }
    }

    public class Dialogo
    {
        public List<Intent> intents { get; set; }
        public List<object> entities { get; set; }
        public Input input { get; set; }
        public Output output { get; set; }
        public Context context { get; set; }
    }
}