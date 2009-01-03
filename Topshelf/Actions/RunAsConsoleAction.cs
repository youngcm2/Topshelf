// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.Actions
{
    using Hosts;
    using log4net;
    using Microsoft.Practices.ServiceLocation;

    /// <summary>
    /// Runs the host as a console
    /// </summary>
    public class RunAsConsoleAction :
        IAction
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof (RunAsConsoleAction));

        public void Do(IInstallationConfiguration configuration, IServiceLocator serviceLocator)
        {
            _log.Info("Received console start notification");

            ConsoleHost inConsoleHost = new ConsoleHost(configuration.Lifecycle);
            inConsoleHost.Run();
        }
    }
}