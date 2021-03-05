using Lamar;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace netflix.web
{
    public class ApplicationRegistry : ServiceRegistry

    {

        public ApplicationRegistry()
            {

            Scan((a) =>
                {
                    a.TheCallingAssembly();
                    a.WithDefaultConventions();
                    a.AssembliesAndExecutablesFromApplicationBaseDirectory(assembly => assembly.GetName().Name.StartsWith
                 ("netflix."));
                });




            }

    }
}
