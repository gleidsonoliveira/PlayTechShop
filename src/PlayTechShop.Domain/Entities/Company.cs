using PlayTechShop.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Domain.Entities
{
    /// <summary>
    /// Empresa
    /// </summary>
    public class Company : EntityBase
    {
        public string Name { get; set; }
        /// <summary>
        /// Razão Social
        /// </summary>
        public string ReasonSocial { get; set; }
        public string Cnpj { get; set; }
        /// <summary>
        /// Endereço
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Bairro
        /// </summary>
        public string AddressNeighborhood { get; set; }
        /// <summary>
        /// Número
        /// </summary>
        public string AdressNumber { get; set; }
        /// <summary>
        /// Complemento
        /// </summary>
        public string AddressComplement { get; set; }
        /// <summary>
        /// CEP
        /// </summary>
        public string AddressZipCode { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Celular
        /// </summary>
        public string CellPhone { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// Inscrição Estadual
        /// </summary>
        public string StateRegistration { get; set; }
        /// <summary>
        /// Responsável Legal
        /// </summary>
        public string LegalResponsible { get; set; }
        /// <summary>
        /// Número de Funcionários
        /// </summary>
        public int NumberOfEmployees { get; set; }
        public string Observation { get; set; }

        //Relacionamento
        //public virtual ICollection<Employee> Clients { get; set; }

        public City City { get; set; }
        public long CityId { get; set; }


    }
}
