namespace FindingBusinessLeadsApp.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using FindingBusinessLeadsApp.Data.Common.Repositories;
    using FindingBusinessLeadsApp.Data.Models;
    using FindingBusinessLeadsApp.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
