using RestSharp;
using APIConsultaUsuario.Bases;

namespace APIConsultaUsuario.Requests
{
    public class ConsultaUsuarioRequest : RequestBase
    {

        public ConsultaUsuarioRequest(string idUsuario)
        {
            requestService = "/users/{idUsuario}";
            method = Method.GET;

            parameters.Add("idUsuario", idUsuario);
        }
    }
}
