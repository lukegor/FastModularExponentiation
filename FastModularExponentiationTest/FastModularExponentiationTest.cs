using FastModularExponentiation;

namespace FastModularExponentiationTest
{
    public class FastModularExponentiationTest
    {
        [Theory]
        [InlineData(450, 289, 520, 320)]    // 450^289 % 520 = 320
        [InlineData(2, 1234, 1117, 1038)]   // 2^1234 % 1117 = 1038
        [InlineData(2, 638, 1019, 396)]     // 2^638 % 1019 = 396
        [InlineData(2, 719, 1019, 486)]     // 2^719 % 1019 = 486
        [InlineData(486, 638, 1019, 498)]   // 486^638 % 1019 = 498
        [InlineData(396, 719, 1019, 498)]   // 396^719 % 1019 = 498
        [InlineData(20, 1001, 1739, 1327)]  // 20^1001 % 1739 = 1327
        [InlineData(1327, 761, 1739, 20)]   // 1327^761 % 1739 = 20
        [InlineData(508, 1001, 1739, 1454)] // 508^1001 % 1739 = 1454
        [InlineData(357, 761, 1739, 1630)]  // 357^761 % 1739 = 1630
        [InlineData(1630, 1001, 1739, 357)] // 1630^1001 % 1739 = 357
        [InlineData(2, 937, 1619, 1454)]    // 2^937 % 1619 = 1454
        [InlineData(1454, 320, 1619, 1154)] // 1454^320 % 1619 = 1154
        [InlineData(2, 195, 1619, 1380)]    // 2^195 % 1619 = 1380
        [InlineData(1454, 195, 1619, 1053)] // 1454^195 % 1619 = 1053
        [InlineData(130, 681, 1619, 571)]   // 130^681 % 1619 = 571
        [InlineData(2, 515, 1619, 1310)]    // 2^515 % 1619 = 1310
        [InlineData(2, 357, 1619, 983)]     // 2^357 % 1619 = 983
        [InlineData(1454, 1310, 1619, 807)] // 1454^1310 % 1619 = 807
        [InlineData(1310, 1579, 1619, 902)] // 1310^1579 % 1619 = 902
        public void FastModularExponentiationTestCalculationTest(int y, int exp, int mod, int expected)
        {
            int result = Program.ModularExponentiation(y, exp, mod);
            Assert.Equal(expected, result);
        }
    }
}