﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProxyForm_P5_20190140024.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMatematika")]
    public interface IMatematika {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        int Kurang(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        System.Threading.Tasks.Task<int> KurangAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        int Kali(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        System.Threading.Tasks.Task<int> KaliAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        int Bagi(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        System.Threading.Tasks.Task<int> BagiAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/TKoordinat", ReplyAction="http://tempuri.org/IMatematika/TKoordinatResponse")]
        ServiceMtk_P1_024.Koordinat TKoordinat(ServiceMtk_P1_024.Koordinat a, ServiceMtk_P1_024.Koordinat b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/TKoordinat", ReplyAction="http://tempuri.org/IMatematika/TKoordinatResponse")]
        System.Threading.Tasks.Task<ServiceMtk_P1_024.Koordinat> TKoordinatAsync(ServiceMtk_P1_024.Koordinat a, ServiceMtk_P1_024.Koordinat b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMatematikaChannel : ClientProxyForm_P5_20190140024.ServiceReference1.IMatematika, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatematikaClient : System.ServiceModel.ClientBase<ClientProxyForm_P5_20190140024.ServiceReference1.IMatematika>, ClientProxyForm_P5_20190140024.ServiceReference1.IMatematika {
        
        public MatematikaClient() {
        }
        
        public MatematikaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MatematikaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Kurang(int a, int b) {
            return base.Channel.Kurang(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KurangAsync(int a, int b) {
            return base.Channel.KurangAsync(a, b);
        }
        
        public int Kali(int a, int b) {
            return base.Channel.Kali(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KaliAsync(int a, int b) {
            return base.Channel.KaliAsync(a, b);
        }
        
        public int Bagi(int a, int b) {
            return base.Channel.Bagi(a, b);
        }
        
        public System.Threading.Tasks.Task<int> BagiAsync(int a, int b) {
            return base.Channel.BagiAsync(a, b);
        }
        
        public ServiceMtk_P1_024.Koordinat TKoordinat(ServiceMtk_P1_024.Koordinat a, ServiceMtk_P1_024.Koordinat b) {
            return base.Channel.TKoordinat(a, b);
        }
        
        public System.Threading.Tasks.Task<ServiceMtk_P1_024.Koordinat> TKoordinatAsync(ServiceMtk_P1_024.Koordinat a, ServiceMtk_P1_024.Koordinat b) {
            return base.Channel.TKoordinatAsync(a, b);
        }
    }
}
