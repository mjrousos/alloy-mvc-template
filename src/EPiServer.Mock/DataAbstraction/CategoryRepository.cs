namespace EPiServer.DataAbstraction
{
    public abstract class CategoryRepository
    {
        protected CategoryRepository() { }
        public abstract void Delete(Category category);
        public abstract Category Get(int id);
        public abstract Category Get(string name);
        public abstract Category GetRoot();
        public abstract void Save(Category category);
    }
}
