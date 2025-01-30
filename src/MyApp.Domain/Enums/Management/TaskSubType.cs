using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Enums.Management
{
    public enum TaskSubType
    {
        // Development SubTypes
        Backend,
        Frontend,
        Database,

        // Testing SubTypes
        UnitTesting,
        IntegrationTesting,
        SystemTesting,

        // Documentation SubTypes
        UserManual,
        TechnicalSpecification,
        APIReference,

        // Maintenance SubTypes
        BugFix,
        PerformanceOptimization,

        // Support SubTypes
        CustomerSupport,
        TechnicalSupport
    }
}
