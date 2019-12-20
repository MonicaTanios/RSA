﻿using System.Collections.Generic;

namespace Crypto.RSA.Tests
{
    internal class DataSet
    {
        public static IEnumerable<string[]> Encrypt()
        {
            return new[]
            {
                new[]
                {
                     "33",
                     "7",
                     "2",
                     "29"
                },
                new[]
                {
                   "713",
                   "223",
                   "439",
                   "284",
                },
                new[]
                {
                   "133",
                    "5",
                    "6",
                    "62"
                },
                new[]
                {
                    "4108597",
                     "17",
                     "67898",
                    "2517819"
                },
                new[]
                {
                    "300217",
                     "17",
                     "33",
                    "4188"
                },
                new[]
                {
                    "3658315382137043",
                     "17",
                     "123456",
                    "1058577239695504"
                },
                new[]
                {
                    "47594980475625417724408267823112764463863576918685226363032787239910118740004860624166859668486833021538759738968887527",
                     "17",
                     "12345678908765435451231232435465767657456453453465475654264325",
                    "41766942386500566296578237070670959299719447915305139877556131342637463900048558377157395064819754504877734317556821079"
                },
                 new[]
                 {
                    "145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053",
                     "65537",
                     "1976620216402300889624482718775150",
                    "35052111338673026690212423937053328511880760811579981620642802346685810623109850235943049080973386241113784040794704193978215378499765413083646438784740952306932534945195080183861574225226218879827232453912820596886440377536082465681750074417459151485407445862511023472235560823053497791518928820272257787786"
                 },

            };
        }
        public static IEnumerable<string[]> Decrypt()
        {
            return new[]
            {
                new[]
                {
                    "33",
                    "3",
                    "29",
                    "2"
                },
                new[]
                {
                    "713",
                    "367",
                    "284",
                    "439"
                },
                new[]
                {
                    "133",
                    "65",
                    "62",
                    "6"
                },
                new[]
                {
                    "4108597",
                    "3378905",
                    "2517819",
                    "67898"
                },
                new[]
                {
                    "300217",
                    "281393",
                    "4188",
                    "33"
                },
                new[]
                {
                    "3658315382137043",
                    "3012726845747393",
                    "1058577239695504",
                    "123456"
                },
                new[]
                {
                    "47594980475625417724408267823112764463863576918685226363032787239910118740004860624166859668486833021538759738968887527",
                    "22397637870882549517368596622641300924171095020557753582603446902846197377658196974714575577237681892436409853219169457",
                    "41766942386500566296578237070670959299719447915305139877556131342637463900048558377157395064819754504877734317556821079",
                    "12345678908765435451231232435465767657456453453465475654264325"
                },
                new[]
                {
                    "145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053",
                    "89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713",
                    "35052111338673026690212423937053328511880760811579981620642802346685810623109850235943049080973386241113784040794704193978215378499765413083646438784740952306932534945195080183861574225226218879827232453912820596886440377536082465681750074417459151485407445862511023472235560823053497791518928820272257787786",
                    "1976620216402300889624482718775150"

                },
            };
        }

        public static IEnumerable<string[]> Encoder()
        {
            return new[]
            {
                new[]
                {
                    "Michael Safwat",
                    "077105099104097101108032083097102119097116",
                },
                new[]
                {
                    "Micheline Medhat",
                    "077105099104101108105110101032077101100104097116",
                },
                new[]
                {
                    "Monica Adel",
                    "077111110105099097032065100101108",
                },
                new[]
                {
                    "Monica Atef",
                    "077111110105099097032065116101102",
                },
                new[]
                {
                    "Youssef Raafat",
                    "089111117115115101102032082097097102097116",
                }
            };
        }

    }
}
