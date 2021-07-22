using Microsoft.AspNetCore.Components;
using PremierProjetBlazorBF.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremierProjetBlazorBF.Client.Pages
{    
    public class ExempleBase :ComponentBase
    {
        private Contact _monContact;


        [Parameter]
        public string info { get; set; }

        [Parameter]
        public EventCallback<string> 
            SendMessage { get; set; }

        private string _message;

        protected string Message
        {
            get { return compose(_message); }
            set { _message = value; }
        }

        public Contact MonContact
        {
            get
            {
                return _monContact;
            }

            set
            {
                _monContact = value;
            }
        }

        public void ChangeTexte(string test)
        {
            Message = test;
            SendMessage.InvokeAsync(test);
            

        }

        public void Send()
        {
            string infos = $"{MonContact.Nom} ({MonContact.Email}) vous transmet ce message : {MonContact.Message}";
            SendMessage.InvokeAsync(infos);
            MonContact.Nom = String.Empty;
            MonContact.Email = string.Empty;
            MonContact.Message = "C'est envoyé!";
        }
        public ExempleBase()
        {
               Message = "Hello le monde";
            MonContact = new Contact()
            {
                Nom = "Votre nom",
                Email="Votre email",
                Message ="Votre message"
                          };

        }

        private string compose(string m)
        {
            return "-->" + m;
        }
        
    }
}
