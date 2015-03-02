using mercadopago;
using System.Collections;

public class MyClass {
	public static void Main () {
		MP mp = new MP("CLIENT_ID", "CLIENT_SECRET");

		Hashtable payment = mp.post("/v1/payments", "{"+
			"'transaction_amount': 100,"+
			"'reason': 'Title of what you are paying for',"+
			"'installments': 1,"+
			"'payment_method_id': 'visa',"+
			"'card': ':CARD',"+
			"'payer': {"+
				"'email': 'payer@email.com'"+
			"},"+
			"'external_reference': '1234'"+
		"}");
	}
}
