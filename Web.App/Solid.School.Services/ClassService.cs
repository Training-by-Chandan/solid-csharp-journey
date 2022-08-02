using Solid.School.Repository;

namespace Solid.School.Services
{
    public interface IClassService
    {
    }

    public class ClassService : IClassService
    {
        private readonly IClassRepository classRepository;

        public ClassService(
            IClassRepository classRepository
            )
        {
            this.classRepository = classRepository;
        }
    }
}