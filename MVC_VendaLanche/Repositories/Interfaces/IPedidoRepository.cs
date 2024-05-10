using MVC_VendaLanche.Models.Entities;

namespace MVC_VendaLanche.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
