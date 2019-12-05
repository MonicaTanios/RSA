﻿namespace Type.BigInteger.Tests
{
    internal class Cases
    {
        internal class Add
        {
            internal class Case1
            {
                internal const string Name = "Case 01";
                internal const string Input1 = "12";
                internal const string Input2 = "12";
                internal const string Output = "24";
            }

            internal class Case2
            {
                internal const string Name = "Case 02";
                internal const string Input1 = "1537983";
                internal const string Input2 = "23606766456";
                internal const string Output = "23608304439";
            }

            internal class Case3
            {
                internal const string Name = "Case 03";
                internal const string Input1 = "377773935827991229645029714898969028";
                internal const string Input2 = "301174256660595384532197942652815288956047581636";
                internal const string Output = "301174256660973158468025933882460318670946550664";
            }

            internal class Case4
            {
                internal const string Name = "Case 04";
                internal const string Input1 = "1242468682113840180763850624340867898830637122775434796573473991466933960634085363735808574823872230131509619596260435331836866582052453403290874467870290043697815376935298110895904163169442926407335197820883439691250684070655002714487685888";
                internal const string Input2 = "417545487977981564551173186152102228498479694796653351848954185997611243506278579601980980219484255929864359810447039931";
                internal const string Output = "1242468682113840180763850624340867898830637122775434796573473991466933960634085363735808574823872230131509619596260435332254412070030434967842047654022392272196295071731951462744858349167054169913613777422864419910734940000519362524934725819";
            }
        }

        internal class Sub
        {
            internal class Case1
            {
                internal const string Name = "Case 01";
                internal const string Input1 = "12";
                internal const string Input2 = "12";
                internal const string Output = "0";
            }

            internal class Case2
            {
                internal const string Name = "Case 02";
                internal const string Input1 = "23606766456";
                internal const string Input2 = "1537983";
                internal const string Output = "23605228473";
            }

            internal class Case3
            {
                internal const string Name = "Case 03";
                internal const string Input1 = "301174256660595384532197942652815288956047581636";
                internal const string Input2 = "377773935827991229645029714898969028";
                internal const string Output = "301174256660217610596369951423170259241148612608";
            }

            internal class Case4
            {
                internal const string Name = "Case 04";
                internal const string Input1 = "1242468682113840180763850624340867898830637122775434796573473991466933960634085363735808574823872230131509619596260435331836866582052453403290874467870290043697815376935298110895904163169442926407335197820883439691250684070655002714487685888";
                internal const string Input2 = "417545487977981564551173186152102228498479694796653351848954185997611243506278579601980980219484255929864359810447039931";
                internal const string Output = "1242468682113840180763850624340867898830637122775434796573473991466933960634085363735808574823872230131509619596260435331419321094074471838739701281718187815199335682138644759046949977171831682901056618218902459471766428140790642904040645957";
            }

            internal class Case5
            {
                internal const string Name = "Case 05";
                internal const string Input1 = "4746065774778736313991013446451762823551152230084842578766104765264199110147300822155702630456369808871508856166675242939783205225636134925618947132215173403355326845258208441126939944538594171280818779612461574891270164910667873484642585292515446565217074728006197739879363128442085702970944395693804734170707191774160806830620562064062100403812906395684974968";
                internal const string Input2 = "1069316615549487026619022949768081235480483137805541651493147788536900481192180243486299495384378377884835399139944321508382197074480783287001843599098432863354215897022904829506300359345726175676489118945707291366438179064337272356680380792";
                internal const string Output = "4746065774778736313991013446451762823551152230084842578766104765264199110147300822155702630456369808871508856166675242938713888610086647898999924182447092167874843707452666789633792156001693690088638536126162079506891787025832474344698263784133249490736291441004354140780930265087869805948039566187504374824981016097671687884913270697623921339475634039004594176";
            }
        }

        internal class Mul
        {
            internal class Case1
            {
                internal const string Name = "Case 01";
                internal const string Input1 = "12";
                internal const string Input2 = "12";
                internal const string Output = "144";
            }

            internal class Case2
            {
                internal const string Name = "Case 02";
                internal const string Input1 = "1537983";
                internal const string Input2 = "23606766456";
                internal const string Output = "36306805494298248";
            }

            internal class Case3
            {
                internal const string Name = "Case 03";
                internal const string Input1 = "377773935827991229645029714898969028";
                internal const string Input2 = "301174256660595384532197942652815288956047581636";
                internal const string Output = "113775784308742720967400704214093299868785809849503488101617302573417961289065569808";
            }

            internal class Case4
            {
                internal const string Name = "Case 04";
                internal const string Input1 = "3100675333279421257617608000138708458801868104897830766303748759001197941598947667658921326203715302820376126044350727358334784388707871335695033578987322915001084651142521380653788065896776145986861827114585345797313243712035560159039288370426232610063160693819476708720025406607223686363847361116574606364158447113777534349736920690749819066439287617387982955";
                internal const string Input2 = "1171369677597009928756935527390310076747104574041487803153297373026018778590309248490666613573253409796114715852296556570425972890140974834424931319354962747988270078167895368091978679700466964125155929802558454004250319697247623603299250283";
                internal const string Output = "3632037065476516989102005880189036681468878216504892153639660828660684602213320010198882230729731518515772216417017389034064434821917690775695012221304270471499211031271008103366533076050537892207842351509250073665317259566599667026115679337363478361006683882015849225829163691690450823411660978084207333975389032098081970107492317775392789688945065895749268771860660129046362314270872481718207373094132958594820374997196658739069990725747261708932784950927123224323202723738348598321078387676384716235726347912313923192938996506531564485946611298023515675476082819069145263138415045041436485082926265";
            }
        }

        internal class Div
        {
            internal class Case1
            {
                internal const string Name = "Case 01";
                internal const string Input1 = "12";
                internal const string Input2 = "12";
                internal const string OutputQ = "1";
                internal const string OutputR = "0";
            }

            internal class Case2
            {
                internal const string Name = "Case 02";
                internal const string Input1 = "23606766456";
                internal const string Input2 = "1537983";
                internal const string OutputQ = "15349";
                internal const string OutputR = "265389";
            }

            internal class Case3
            {
                internal const string Name = "Case 03";
                internal const string Input1 = "301174256660595384532197942652815288956047581636";
                internal const string Input2 = "377773935827991229645029714898969028";
                internal const string OutputQ = "797234081277";
                internal const string OutputR = "370442265729151065970477043989892880";
            }

            internal class Case4
            {
                internal const string Name = "Case 04";
                internal const string Input1 = "3100675333279421257617608000138708458801868104897830766303748759001197941598947667658921326203715302820376126044350727358334784388707871335695033578987322915001084651142521380653788065896776145986861827114585345797313243712035560159039288370426232610063160693819476708720025406607223686363847361116574606364158447113777534349736920690749819066439287617387982955";
                internal const string Input2 = "1171369677597009928756935527390310076747104574041487803153297373026018778590309248490666613573253409796114715852296556570425972890140974834424931319354962747988270078167895368091978679700466964125155929802558454004250319697247623603299250283";
                internal const string OutputQ = "2647051048512932864429040928845798413827117330963997870707370679721005794357134889279718379251895326532752534790995283309";
                internal const string OutputR = "980400196378574432315750614403715935867451927503067520749048038198648040831301046577633912910245270718139737022651702431299775870337375693604120076172944094278867472937777727952877581772455177989091808851514918884779072879286260908504556508";
            }
        }

    }
}