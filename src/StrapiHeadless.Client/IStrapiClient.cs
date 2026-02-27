using RestEase;
using StrapiHeadless.Client.Commands;
using StrapiHeadless.Client.Models;

namespace StrapiHeadless.Client;

public interface IStrapiClient
{
    [Header("Authorization")] public string Authorization { get; set; }
    
    [Get("/products")]
    Task<StrapiDocument<IList<ProductEntity>>> GetProducts();
    
    [Get("/products/{documentId}")]
    Task<StrapiDocument<ProductEntity>> FindProduct([Path] string documentId);
    
    [Post("/products")]
    Task<StrapiDocument> CreateProduct([Body] CreateProductCommand request);
    
    [Post("/categories")]
    Task<StrapiDocument> CreateCategory([Body] CreateCategoryCommand request);
    
    [Get("/categories")]
    Task<StrapiDocument<IList<CategoryEntity>>> GetCategories();
}