namespace Books.Interfaces
{
    
    ///The importer interface creates the contract that the devloper intends to import something
    public interface IImporter
    {
        ///<Summary>
        /// Interface for importing a xml url
        ///</Summarry>
        void Import();
    }
}