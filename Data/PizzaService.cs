namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public async Task<Pizza[]> GetPizzasAsync()
        {
            Pizza[] pizza = new Pizza[5];
            pizza.Append(new Pizza { PizzaId = 1, Name = "Pizza1" });
            pizza.Append(new Pizza { PizzaId = 2, Name = "Pizza2" });
            pizza.Append(new Pizza { PizzaId = 3, Name = "Pizza3" });
            pizza.Append(new Pizza { PizzaId = 4, Name = "Pizza4" });
            pizza.Append(new Pizza { PizzaId = 5, Name = "Pizza5" });
            return pizza;
        }
    }
}
