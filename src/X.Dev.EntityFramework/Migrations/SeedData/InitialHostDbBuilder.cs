using X.Dev.EntityFramework;
using EntityFramework.DynamicFilters;

namespace X.Dev.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly DevDbContext _context;

        public InitialHostDbBuilder(DevDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
