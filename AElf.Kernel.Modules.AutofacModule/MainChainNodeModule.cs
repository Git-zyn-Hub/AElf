﻿using Autofac;
using AElf.Configuration;
using AElf.Kernel.Node;

namespace AElf.Kernel.Modules.AutofacModule
{
    public class MainChainNodeModule : Module
    {
        private INodeConfig _nodeConfig;
        public MainChainNodeModule(INodeConfig nodeConfig)
        {
            _nodeConfig = nodeConfig;
        }

        protected override void Load(ContainerBuilder builder)
        {
            if (_nodeConfig != null)
            {
                builder.RegisterInstance(_nodeConfig).As<INodeConfig>();
            }
            builder.RegisterType<MainChainNode>().As<IAElfNode>();
            
        }
    }
}