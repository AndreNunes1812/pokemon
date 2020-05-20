namespace PokeApi.Model
{
  public class PokemonWeakness
  {
    public int Id { get; set; }
    public int PokemonId { get; set; }
    public int TypeElementId { get; set; }
    public Pokemon Pokemon { get; set; }
    public TypeElement TypeElement { get; set; }
  }
}