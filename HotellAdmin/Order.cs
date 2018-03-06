using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class Order {

		public string firstName;
		public string lastName;
		public string roomType;
        public int bestillingID;
        public string fraDato;
        public string tilDato;


        public Order(string firstName, string lastName, int bestillingID, string fraDato, string tilDato) {
			this.firstName = firstName;
			this.lastName = lastName;
            this.bestillingID = bestillingID;
            this.fraDato = fraDato;
            this.tilDato = tilDato;
		}

	}

}
