using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities {

    /// <summary>
    /// Empresa
    /// </summary>
    public class Company : EntityBase {
        public string Name { get; set; }

        /// <summary>
        /// Razão Social
        /// </summary>
        public string ReasonSocial { get; set; }

        public string Cnpj { get; set; }

        /// <summary>
        /// Endereço
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        public string AdressNeighborhood { get; set; }

        /// <summary>
        /// Número
        /// </summary>
        public string AdressNumber { get; set; }

        /// <summary>
        /// Complemento
        /// </summary>
        public string Complement { get; set; }

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
        public long CityId { get; set; }
        public City City { get; set; }
    }
}