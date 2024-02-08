namespace Recipes.Objects
{
    public class CurrentSubstitutions
    {
        public int SubstitutionID { get; set; }
        public int IngrediantNameID { get; set; }
        public int IngrediantSubstitutionID { get; set; }
        public string IngrediantSubstitutionName { get; set; }

        public CurrentSubstitutions() { }
    }
}