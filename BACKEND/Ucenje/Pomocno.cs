

        /// <summary>
        /// Učitava decimalni broj s konzole.
        /// Prikazuje poruku korisniku i zahtijeva unos decimalnog broja.
        /// Ako unos nije broj, ispisuje poruku o pogrešci i ponavlja unos.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni broj.</returns>
        public static decimal UcitajDecimalniBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return decimal.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokušajte ponovo");
                }
            }
        }
    }
}

        