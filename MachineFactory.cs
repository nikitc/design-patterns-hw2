namespace Patterns1
{
    public interface IMachineFactory
    {
        IHood CreateHood();
        IEngine CreateEngine();
        ISalon CreateSalon();

    }

    public interface IHood
    {
        string Type { get; }
    }
    public interface IEngine
    {
        string Power { get; }
    }

    public interface ISalon
    {
        string Form { get; }
    }

    public class AudiFactory : IMachineFactory
    {
        public IHood CreateHood()
        {
            return new SteelHood();
        }
        public IEngine CreateEngine()
        {
            return new PowerfulEngine();
        }

        public ISalon CreateSalon()
        {
            return new SpaciousSalon();
        }

    }

    public class SteelHood : IHood
    {
        public string Type => "Стальной капот";
    }

    public class PowerfulEngine: IEngine
    {
        public string Power => "80 л.с";
    }

    public class SpaciousSalon : ISalon
    {
        public string Form => "Просторный салон";
    }

    public class BmwFactory : IMachineFactory
    {
        public IHood CreateHood()
        {
            return new AluminumHood();
        }
        public IEngine CreateEngine()
        {
            return new MiddleEngine();
        }

        public ISalon CreateSalon()
        {
            return new NarrowSalon();
        }

    }


    public class AluminumHood : IHood
    {
        public string Type => "Алюминиевый капот";
    }

    public class MiddleEngine : IEngine
    {
        public string Power => "50 л.с";
    }

    public class NarrowSalon : ISalon
    {
        public string Form => "Узкий салон";
    }

}
