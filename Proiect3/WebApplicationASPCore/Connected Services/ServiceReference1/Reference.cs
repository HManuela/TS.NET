﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://localhost/8000")]
    public partial class MyPhotos : object
    {
        
        private int IdField;
        
        private ServiceReference1.MyPhotos[] Field;
        
        private string DateMemoryField;
        
        private string PathPhotoField;
        
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.MyPhotos[] Photo
        {
            get
            {
                return this.Field;
            }
            set
            {
                this.Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateMemory
        {
            get
            {
                return this.DateMemoryField;
            }
            set
            {
                this.DateMemoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PathPhoto
        {
            get
            {
                return this.PathPhotoField;
            }
            set
            {
                this.PathPhotoField = value;
            }
        }
 
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auto", Namespace= "http://localhost/8000")]
    public partial class DetaliuPhoto : object
    {
        
        private ServiceReference1.MyPhotos Photo;
        
        private int IdField;
        
        private string TitleField;
        
        private string DateField;
        
        private string PeopleField;
        
        private string LocationField;

        private string EventField;

        private string DescriptionField;


        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.MyPhotos Field
        {
            get
            {
                return this.Field;
            }
            set
            {
                this.Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }


    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sasiu", Namespace= "http://localhost/8000")]
    public partial class Search : object
    {
        
        private int IdField;

        private string DateField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comanda", Namespace= "http://localhost/8000")]
    public partial class User : object
    {
        
        private int IdField;
        
        private string NumeField;

        private string PrenumeField;

        private string AdresaField;

        private string LocalitateField;

        private string JudetField;

        private string TelefonField;

        private string EmailField;

        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
     
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nume
        {
            get
            {
                return this.NumeField;
            }
            set
            {
                this.NumeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenume
        {
            get
            {
                return this.PrenumeField;
            }
            set
            {
                this.PrenumeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adresa
        {
            get
            {
                return this.AdresaField;
            }
            set
            {
                this.AdresaField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Localitate
        {
            get
            {
                return this.LocalitateField;
            }
            set
            {
                this.LocalitateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Judet
        {
            get
            {
                return this.JudetField;
            }
            set
            {
                this.JudetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefon
        {
            get
            {
                return this.TelefonField;
            }
            set
            {
                this.TelefonField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }


      
    }
    
  
      
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyPhotos")]
    public interface IMyPhotos
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/FindUser", ReplyAction="http://tempuri.org/IMyPhotos/FindUserResponse")]
        System.Threading.Tasks.Task<ServiceReference1.User> FindUserAsync(string nume, string prenume, string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/AddUser", ReplyAction="http://tempuri.org/IMyPhotos/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/GetAllUsers", ReplyAction="http://tempuri.org/IMyPhotos/GetAllUsersResponse")]
        System.Threading.Tasks.Task<ServiceReference1.User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/AddImage", ReplyAction="http://tempuri.org/IMyPhotos/AddImageResponse")]
        System.Threading.Tasks.Task AddImageAsync(ServiceReference1.MyPhotos photo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/FindPhotoById", ReplyAction="http://tempuri.org/IMyPhotos/FindPhotoByIdResponse")]
        System.Threading.Tasks.Task FindPhotoByIdAsync(int id );

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhotos/FindUserById", ReplyAction = "http://tempuri.org/IMyPhotos/FindUserByIdResponse")]
        System.Threading.Tasks.Task FindUserByIdAsync(int id);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/UpdatePhoto", ReplyAction="http://tempuri.org/IMyPhotos/UpdatePhotoResponse")]
        System.Threading.Tasks.Task UpdatePhotoAsync(ServiceReference1.MyPhotos photo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/DeletePhotos", ReplyAction="http://tempuri.org/IMyPhotos/DeletePhotosResponse")]
        System.Threading.Tasks.Task DeletePhotosAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyPhotos/ExistsPhoto", ReplyAction="http://tempuri.org/IMyPhotos/ExistsPhotoResponse")]
        System.Threading.Tasks.Task<bool> ExistsPhotoAsync(int id);
         
    }
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public partial class MyPhotosClient : System.ServiceModel.ClientBase<ServiceReference1.IMyPhotos>
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyPhotosClient(EndpointConfiguration endpointConfiguration) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), MyPhotosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public MyPhotosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public MyPhotosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyPhotosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public MyPhotosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task AddUserAsync(ServiceReference1.User user)
        {
            return base.Channel.AddUserAsync(user);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.User[]> GetAllUsersAsync()
        {
            return base.Channel.GetAllUsersAsync();
        }
        
        public System.Threading.Tasks.Task AddImageAsync(ServiceReference1.MyPhotos photo)
        {
            return base.Channel.AddImageAsync(photo);
        }
        
       
        public System.Threading.Tasks.Task UpdatePhotoAsync(ServiceReference1.MyPhotos photo)
        {
            return base.Channel.UpdatePhotoAsync(photo);
        }
       
        
        public System.Threading.Tasks.Task DeletePhotosAsync(int id)
        {
            return base.Channel.DeletePhotosAsync(id);
        }
        
        public System.Threading.Tasks.Task<bool> ExistsPhotoAsync(int id)
        {
            return base.Channel.ExistsPhotoAsync(id);
        }
       
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotos))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotos))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyPhotosClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMyPhotos);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyPhotosClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMyPhotos);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMyPhotos,
        }
    }
}
