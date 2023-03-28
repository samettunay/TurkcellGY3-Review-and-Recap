using SingleResponsibility;

void buttonAddProduct_Click(string name, decimal price)
{
    ProductService productService = new ProductService();
    string name1 = name;
    decimal price1 = price;
    var affectedRows = productService.AddProduct(name, price);

    string message = affectedRows > 0 ? "Başarılı" : "İşlem yapılamadı";
    Console.WriteLine(message);
}