using Microsoft.AspNetCore.Mvc;
using PlayTechShop.Domain.Interface.Service;

namespace PlayTechShop.WebApi.Controllers;
public class ClientController : Controller
{
    private readonly IClientService _clientService;
    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }
}
