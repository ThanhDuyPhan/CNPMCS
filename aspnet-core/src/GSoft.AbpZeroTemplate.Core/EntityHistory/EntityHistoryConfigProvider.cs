﻿using System.Collections.Generic;
using System.Linq;
using Abp.Configuration;
using Abp.Configuration.Startup;

namespace GSoft.AbpZeroTemplate.EntityHistory
{
    public class EntityHistoryConfigProvider : ICustomConfigProvider
    {
        private static Dictionary<string, object> EntityHistoryConfig => new Dictionary<string, object>();
        private readonly IAbpStartupConfiguration _abpStartupConfiguration;

        public EntityHistoryConfigProvider(IAbpStartupConfiguration abpStartupConfiguration)
        {
            _abpStartupConfiguration = abpStartupConfiguration;
        }

        public Dictionary<string, object> GetConfig(CustomConfigProviderContext customConfigProviderContext)
        {
            if (!_abpStartupConfiguration.EntityHistory.IsEnabled)
            {
                return EntityHistoryConfig;
            }

            foreach (var type in EntityHistoryHelper.TrackedTypes)
            {
                if (_abpStartupConfiguration.EntityHistory.Selectors.Any(s => s.Predicate(type)))
                {
                    EntityHistoryConfig.Add(type.FullName ?? "", type.FullName);
                }
            }

            return EntityHistoryConfig;
        }
    }
}
