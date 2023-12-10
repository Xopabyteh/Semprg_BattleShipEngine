using BattleShipEngine;

namespace BattleShipStrategies.Slavek.AI;

public partial record struct Experiences
{
    public static Experiences SmallChatGPT()
    {
        GameSetting s = new GameSetting(5,5, new int[] {2,1,1});
        Experiences e = new Experiences("SmallChatGPT", s,
            new CoefficientMap(s, new double[,] 
{{0.3701,0.1531,0.2982,0.1515,0.3625},
{0.423,0.0808,0.3523,0.0804,0.418},
{0.5317,0.0723,0.4232,0.0714,0.5203},
{0.4183,0.0813,0.3439,0.0889,0.4171},
{0.3612,0.1596,0.3051,0.1597,0.3561}}),
            new Dictionary<(Int2,SlavekTile),CoefficientMap?>());
        e.AddChange(new Int2(0,0),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{2.7019724398811134,0,0.9260281131986913,0.8721217974269732,0.787857894883955},
{1.506844677465614,0,1.0683643510514875,1.1560678100983868,0.9211269681412887},
{1.0971522470760438,0.5867353707625653,0.9066164613967818,1.070949860625147,0.8381671185793036},
{0.6304387045957367,0.9671266666733136,0.8029705825991561,1.340348533169371,0.8661081640184722},
{0.9575096132469061,1.301890229491589,0.7084817934791513,0.9762292409589244,0.7519389744235279}}));
        e.AddChange(new Int2(0,0),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0,1.5875535799333227,1.0434624469045313,1.0751352957172204,1.1246448533155236},
{0.7022015952849283,1.587553579933323,0.9598322807998801,0.9083017994643389,1.046342132228781},
{0.9429178494319039,1.2428151123682718,1.0548678324131624,0.9583131553939245,1.095085488829655},
{1.2171370621195712,1.0193148446804359,1.1157653395460427,0.8000270009112808,1.0786686275547919},
{1.0249653788495316,0.8226233149153246,1.1712825658570665,1.0139665945723162,1.1457491436193876}}));
        e.AddChange(new Int2(0,1),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0,6.531678641410842,0,1.828007751787589,0.8216401270298881},
{0,4.1469692364403,0,2.6809128752059426,0.8500557849108848},
{0.7063598305080374,3.69496066989908,0.5741456650767565,2.351038390535835,0.7959031825205601},
{1.1445662070652995,2.0326134025546656,0.9648423233023287,2.079263279549233,0.8691157146926438},
{1.329120653775462,1.2891471002784558,0.9997685760533804,1.4192188406822555,0.8730915566727213}}));
        e.AddChange(new Int2(0,1),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.1807769512339121,0,1.1807769512339117,0.850315283033794,1.0322433540580047},
{1.180776951233912,0.43110049580941096,1.180776951233912,0.6961296951304405,1.0271064580589722},
{1.0530833746005663,0.5128132264003435,1.0769846483371692,0.7557633987589604,1.0368960004204775},
{0.9738657618352847,0.8133272972828914,1.0063556976058725,0.8048940747443764,1.0236608620622933},
{0.94050257162236,0.9477288687535346,1.0000418361155123,0.9242148960816468,1.0229421214705472}}));
        e.AddChange(new Int2(0,2),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.9260281131986914,0,3.3534540576794094,0,0.9454427715719605},
{1.1130613468042296,0,1.6553098513495583,0,1.0902736996139517},
{0.9820063885286519,0.3942511686068462,1.193360541319752,0.3616470062203285,0.9796752196180479},
{0.8658212723628407,0.7795852606413388,0.7118410765065337,0.7468885302818034,0.8570563475152841},
{0.6823889070859264,1.033771551615457,1.013400406811018,0.9764283887419696,0.6818030715416715}}));
        e.AddChange(new Int2(0,2),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0314312006898694,1.4249073810202335,0,1.4249073810202337,1.023181769047081},
{0.9519593992347944,1.4249073810202337,0.7215540073063005,1.4249073810202337,0.9616420387220286},
{1.0076456183253863,1.257387149503332,0.9178396787951694,1.2712408987533457,1.0086361492019067},
{1.0570135317489326,1.0936558496391462,1.1224408534992187,1.107548931704141,1.060737813010747},
{1.134955297673093,0.9856502184500865,0.9943060682373247,1.0100157516060766,1.135204223519911}}));
        e.AddChange(new Int2(0,3),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.8721217974269733,1.8280077517875888,0,6.600660066006601,0},
{0.8067473414008067,2.7938437408097245,0,3.9242730243173574,0},
{0.784580997125479,2.401069982516924,0.6051644862028737,3.6793595325919144,0.6977441930239536},
{0.8915546108758617,1.9404154437583983,0.9923062675560955,2.108647310175337,1.174224351229177},
{0.9100577831869565,1.3399836224223927,0.9627314747207268,1.2399486661252224,1.2882501392514987}}));
        e.AddChange(new Int2(0,3),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.022832702050458,0.8521588987674488,1.1785503830288744,0,1.1785503830288746},
{1.0345053362142342,0.6797085129844747,1.1785503830288744,0.4778699314271307,1.1785503830288746},
{1.038463145474944,0.7498384179713447,1.0704980322218793,0.5215993291836475,1.0539678901082747},
{1.0193629657658303,0.8320884623106691,1.0013737188747809,0.802050598124262,0.9688921753550732},
{1.016059217262435,0.9392957939929375,1.0066543094635356,0.957157073756074,0.9485328272285184}}));
        e.AddChange(new Int2(0,4),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.787857894883955,0.8216401270298879,0.9454427715719604,0,2.7586206896551726},
{0.9104100432053477,1.0720382383065894,1.022639404112874,0,1.5357201781884178},
{0.8456933842651743,0.9538799065197691,0.9184538165699758,0.5447696319907273,1.0953892648140662},
{0.9074496937522154,1.323323578063367,0.8510894305682286,0.9650517823203133,0.6078092576823552},
{0.7782487493794631,0.9039840981764756,0.7070604324189921,1.3041694556603975,0.9605980497535561}}));
        e.AddChange(new Int2(0,4),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.120629824477751,1.1014203199241812,1.031022737733591,1.5686274509803921,0},
{1.0509433087655866,0.9590370801786061,0.9871266133475813,1.5686274509803921,0.6953748006379586},
{1.087742977574705,1.026225151194641,1.046369398420994,1.2588564837699785,0.945759045497884},
{1.0526266447291324,0.8161493379639679,1.084674637520027,1.019872515935508,1.2230104221021902},
{1.12609384839207,1.0545972775074943,1.166573479604887,0.8270408977617345,1.0224050305322916}}));
        e.AddChange(new Int2(1,0),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{1.5068446774656137,0,1.1130613468042294,0.8067473414008067,0.9104100432053477},
{2.3640661938534278,0,1.1669347462705395,0.6939298777977724,0.9478887418417095},
{1.16135807755222,0,1.049640921136718,0.7218017230532874,0.937357016705674},
{0.4984715235426066,0.4100041000410004,0.9273408826717867,0.9333939640523656,0.9941433958328727},
{0.605415622733782,1.1361145179734207,0.8755800717975659,0.8807885944538445,0.9207974756738848}}));
        e.AddChange(new Int2(1,0),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0.6284310250122104,1.7331022530329288,0.9171144719268818,1.141673959423672,1.0656785991752824},
{0,1.733102253032929,0.877619761399587,1.224380696172517,1.0382028807642234},
{0.8817080298014055,1.733102253032929,0.963608128872042,1.2039477836195136,1.0459237121897744},
{1.3676716560510873,1.4325273235401332,1.0532665626166973,1.0488290350188028,1.0042934897100428},
{1.2892706959854596,0.9002141402031942,1.0912125296873998,1.0873941499931088,1.0580635490293702}}));
        e.AddChange(new Int2(1,1),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0,4.1469692364403,0,2.7938437408097245,1.0720382383065894},
{0,12.376237623762377,0,2.9555194325402687,0.7550097114974655},
{0,6.0597346041658104,0,3.848073883018554,0.9847707815178981},
{0.45563963520425677,1.6897446202184796,0.47144144481328043,2.631168628673891,0.8871961279081636},
{1.003941756301876,1.907615573587434,0.7747824929985624,2.0381656199433342,1.2685556676981935}}));
        e.AddChange(new Int2(1,1),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0879025239338556,0.7233734613746994,1.0879025239338553,0.8423166076398764,0.9936676570331022},
{1.0879025239338556,0,1.0879025239338556,0.8281049062780095,1.0215352646986562},
{1.0879025239338556,0.5552365578583578,1.0879025239338553,0.7496471173325726,1.001338686742117},
{1.0478506499951001,0.9393697070129972,1.0464616310477448,0.856616160577839,1.0099157450663843},
{0.9996535096723329,0.9202183003199907,1.019797187299517,0.908742621745625,0.9763932789925869}}));
        e.AddChange(new Int2(1,2),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{1.0683643510514875,0,1.655309851349558,0,1.0226394041128741},
{1.1669347462705397,0,2.838489923360772,0,1.132679711044442},
{1.0426125296828264,0,1.1871756059424778,0,1.0458168716284066},
{0.9038653066977166,0.4748273426532165,0.5686884434997301,0.46297079739855107,0.9343674573901557},
{0.8117829708836316,1.0244174159497523,0.721019236514126,0.9935603426165757,0.8250033896878401}}));
        e.AddChange(new Int2(1,2),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0.9628149438390627,1.543924656476764,0.6435608142188523,1.5439246564767641,0.9876858698950663},
{0.909200075480761,1.543924656476764,0,1.543924656476764,0.9278322337487156},
{0.976821994430663,1.543924656476764,0.8981905728369076,1.543924656476764,0.9750790738386789},
{1.0522900300299436,1.2856543572383385,1.2346009902038677,1.2921034245429834,1.035699158192756},
{1.1023758829051975,0.9867187654174807,1.1517445159426793,1.003502688430107,1.0951849711486397}}));
        e.AddChange(new Int2(1,3),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{1.1560678100983868,2.6809128752059426,0,3.9242730243173574,0},
{0.6939298777977724,2.955519432540269,0,12.437810945273633,0},
{1.0035397584206112,3.9050941695395776,0,6.027286536505149,0},
{0.9574408616729881,2.4171883509879875,0.4448533719885597,1.7628393465742156,0.4979895535508742},
{1.3877181093425452,1.8781406251948278,0.8030969374693233,1.8224469387564368,0.9465450059447217}}));
        e.AddChange(new Int2(1,3),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0.9863550979426814,0.8530389352255786,1.0874293170943887,0.7443328064863902,1.087429317094389},
{1.026759501767137,0.8290302714481975,1.087429317094389,0,1.087429317094389},
{0.9996905213386069,0.746009600662264,1.087429317094389,0.5604677712755394,1.087429317094389},
{1.0037209164000562,0.8760961902789972,1.048536090574293,0.9333054768762864,1.0438904305072962},
{0.9661020704750537,0.9232247648263765,1.0172151002908507,0.928094025798154,1.0046735336255375}}));
        e.AddChange(new Int2(1,4),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.9211269681412886,0.8500557849108846,1.0902736996139515,0,1.535720178188418},
{0.9478887418417095,0.7550097114974655,1.132679711044442,0,2.3923444976076556},
{0.9394800284003734,0.7875214252152448,1.024886714121616,0,1.1651356826711126},
{0.9728371958954392,0.9592918895696134,0.9043465678656448,0.5166818262549717,0.4754863554343674},
{0.9266029767865752,0.9083714069863655,0.8617458547593619,1.1909291644321138,0.6086672605539274}}));
        e.AddChange(new Int2(1,4),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0566476414380437,1.1076918933114264,0.9351642501054436,1.718213058419244,0.6152387723663941},
{1.0374269860999408,1.1759552243884182,0.9047076989405897,1.718213058419244,0},
{1.0434662338980139,1.152604887044721,0.9821260369367087,1.7182130584192439,0.8813973962946304},
{1.0195086806111793,1.0292370964946762,1.068699544041513,1.3471254237550203,1.3767125488461072},
{1.0527147005209818,1.0658088520269748,1.099295932492417,0.8628721808717806,1.2810602836571447}}));
        e.AddChange(new Int2(2,0),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{1.0971522470760435,0.7063598305080373,0.9820063885286517,0.784580997125479,0.8456933842651742},
{1.16135807755222,0,1.0426125296828264,1.003539758420611,0.9394800284003733},
{1.880759826970096,0,0.960822955082549,0.5874081812525649,0.8122366579284654},
{1.1505771927364272,0,1.0401876100311493,0.9752871543680699,0.9604455601645419},
{1.0903408299212018,0.7317994063586652,0.9721265968967032,0.772560079206251,0.8635333662162613}}));
        e.AddChange(new Int2(2,0),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0.8896949609858374,1.3333941450328348,1.0204296459946955,1.2445831386469846,1.1751971547858358},
{0.8167967332169221,2.135383301302584,0.9516184453718584,0.9959810173985932,1.0687133651495229},
{0,2.135383301302584,1.044480962593655,1.4684498612599,1.2131833631847853},
{0.8290371698100397,2.135383301302584,0.9543716586513729,1.0280585522581618,1.0449094504815568},
{0.8974285302816506,1.3045104754198116,1.031646996433959,1.2582314881188048,1.1549419371830318}}));
        e.AddChange(new Int2(2,1),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.5867353707625654,3.6949606698990793,0.3942511686068462,2.401069982516924,0.9538799065197692},
{0,6.0597346041658104,0,3.905094169539577,0.7875214252152448},
{0,13.831258644536652,0,3.2931568201277743,0.5210314615278078},
{0,6.2776561375572255,0,3.967346405350783,0.6963712096266356},
{0.6011925822791402,3.717800725881093,0.3264013839418679,2.3730525163450484,0.8661529563975494}}));
        e.AddChange(new Int2(2,1),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0322076454606732,0.7899691102363873,1.047208839613803,0.8908080632359884,1.0035943545959047},
{1.0779346771585643,0.605671217116322,1.077934677158564,0.7735924237817059,1.0165594491289618},
{1.0779346771585643,0,1.077934677158564,0.8212835635493821,1.0373282584149397},
{1.077934677158564,0.5886875727655628,1.0779346771585643,0.7687408158813608,1.0236632117537936},
{1.0310809273485158,0.7881890778471456,1.0524966906769462,0.8929915954168944,1.0104313261317852}}));
        e.AddChange(new Int2(2,2),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.9066164613967819,0.5741456650767565,1.193360541319752,0.6051644862028737,0.9184538165699758},
{1.0496409211367181,0,1.1871756059424778,0,1.0248867141216162},
{0.9608229550825492,0,2.3629489603024574,0,0.9827833077252581},
{1.0314952908229231,0,1.1962472055500375,0,1.0486258752145405},
{0.8916665096600912,0.6366341183772285,1.1648230862979012,0.5962858052610459,0.9230165694413699}}));
        e.AddChange(new Int2(2,2),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0685158001679644,1.3124506840144186,0.8581307540108891,1.289692076003717,1.059830694916065},
{0.963578297806763,1.7337031900138695,0.8626686608272248,1.7337031900138695,0.9817405384600071},
{1.0287443228312507,1.7337031900138695,0,1.7337031900138695,1.0126319420434653},
{0.9768918046528067,1.7337031900138695,0.85601279925663,1.7337031900138693,0.9643230402378751},
{1.0794846274477277,1.2666027064888297,0.8790687757952987,1.296206392533851,1.056482988579078}}));
        e.AddChange(new Int2(2,3),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{1.070949860625147,2.351038390535835,0.3616470062203285,3.679359532591915,0.5447696319907274},
{0.7218017230532876,3.848073883018554,0,6.02728653650515,0},
{0.587408181252565,3.2931568201277743,0,14.005602240896357,0},
{0.7566976109114456,3.8416350550060123,0,5.797594628402541,0},
{1.0004001600640255,2.1412073601370376,0.41773510453017654,3.516747964057257,0.5427613336825884}}));
        e.AddChange(new Int2(2,3),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0.9945446693424127,0.8961187367173609,1.0490829245701794,0.7939842013492756,1.0350026365236509},
{1.0213906493366307,0.7810117647560578,1.0768899418479432,0.6134522305551716,1.0768899418479432},
{1.0317241609504275,0.8236793054521612,1.0768899418479432,0,1.0768899418479432},
{1.0187075065484847,0.7815068458675111,1.0768899418479432,0.6311132280121241,1.076889941847943},
{0.9999692317159471,0.9122526324426186,1.0447703139527735,0.8064873953977081,1.0351570544637767}}));
        e.AddChange(new Int2(2,4),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.8381671185793036,0.79590318252056,0.9796752196180477,0.6977441930239536,1.0953892648140662},
{0.9373570167056741,0.9847707815178981,1.0458168716284066,0,1.1651356826711128},
{0.8122366579284654,0.5210314615278078,0.9827833077252581,0,1.9219680953296177},
{0.9561595998998169,0.9574379810682597,1.0249751342932594,0,1.1575123125073121},
{0.8715901827657567,0.7947988364145034,0.9732680128758635,0.7293128777518774,1.08916922672709}}));
        e.AddChange(new Int2(2,4),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.1755298065524042,1.221370802865442,1.02204499318893,1.3278375992696205,0.896537347336338},
{1.0679448492975565,1.0165181621351629,0.9503053610417761,2.0846362309776945,0.8208878555476758},
{1.203654923660245,1.5195066303253733,1.0186738482187787,2.084636230977694,0},
{1.0475508863292167,1.0461643077969243,0.9729110644719975,2.0846362309776945,0.8291564390294881},
{1.139277940185484,1.2225686166636103,1.0289944817608678,1.293597060049402,0.9032838260035334}}));
        e.AddChange(new Int2(3,0),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.6304387045957367,1.1445662070652993,0.8658212723628407,0.8915546108758617,0.9074496937522155},
{0.49847152354260665,0.4556396352042567,0.9038653066977166,0.9574408616729881,0.9728371958954393},
{1.1505771927364274,0,1.0314952908229231,0.7566976109114456,0.956159599899817},
{2.390628735357399,0,1.1511721970781776,0.6964823874663287,0.9812410440977862},
{1.5361709010975975,0,1.1110821195466378,0.7933833623916228,0.9324861874224731}}));
        e.AddChange(new Int2(3,0),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.2657512289283195,0.8960425573054586,1.0964878146306063,1.0779829916978287,1.0665528504442983},
{1.360648722197228,1.3914490984941714,1.0691303802790875,1.0306042419841654,1.0195327504846792},
{0.8917200623660865,1.7190991920233798,0.9773517618166946,1.1749585514109373,1.0315255962900234},
{0,1.7190991920233798,0.8912921952246834,1.218259269937828,1.0134895500324839},
{0.61443993823427,1.71909919202338,0.9201209375857684,1.1485778571627716,1.0485491280749173}}));
        e.AddChange(new Int2(3,1),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.9671266666733136,2.0326134025546656,0.7795852606413387,1.940415443758398,1.323323578063367},
{0.41000410004100046,1.6897446202184796,0.4748273426532165,2.4171883509879875,0.9592918895696134},
{0,6.277656137557226,0,3.841635055006012,0.9574379810682597},
{0,12.300123001230013,0,3.016228137534468,0.7224958368020507},
{0,4.007558872581207,0,2.6571962651373537,1.1018644306072378}}));
        e.AddChange(new Int2(3,1),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.002909112876303,0.9086192776448303,1.0195055168279734,0.9167783002312422,0.9713876054244567},
{1.0522114582199484,0.938961317488013,1.0464749505195314,0.8745864668168898,1.0036024484358228},
{1.088494611951671,0.5329558680925193,1.0884946119516707,0.748530608498978,1.003766509349244},
{1.088494611951671,0,1.088494611951671,0.8215746733628471,1.0245576232371756},
{1.0884946119516707,0.7338472446491214,1.088494611951671,0.8533470595889115,0.9909855467417346}}));
        e.AddChange(new Int2(3,2),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.8029705825991561,0.9648423233023286,0.7118410765065336,0.9923062675560955,0.8510894305682285},
{0.9273408826717866,0.47144144481328043,0.5686884434997301,0.4448533719885597,0.9043465678656447},
{1.0401876100311493,0,1.1962472055500373,0,1.0249751342932594},
{1.1511721970781776,0,2.907822041291073,0,1.1733072393893251},
{1.0449482307851088,0,1.6430957716112127,0,1.1154408616690832}}));
        e.AddChange(new Int2(3,2),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.1032745262066002,1.0184281740837207,1.1510407769995474,1.004032730662184,1.078052651771965},
{1.0380848505550566,1.2770481437718533,1.226075360890783,1.290984492262055,1.0501375023792179},
{0.9789353466091874,1.5241579027587258,0.8971354763166317,1.5241579027587258,0.9869090859877276},
{0.9207618982240737,1.524157902758726,0,1.5241579027587255,0.9091596408687868},
{0.976440029618962,1.524157902758726,0.6629162690792624,1.5241579027587258,0.9394907600548731}}));
        e.AddChange(new Int2(3,3),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{1.3403485331693712,2.079263279549233,0.7468885302818032,2.1086473101753374,0.9650517823203134},
{0.9333939640523657,2.6311686286738913,0.4629707973985511,1.7628393465742156,0.5166818262549717},
{0.9752871543680701,3.967346405350783,0,5.797594628402542,0},
{0.6964823874663288,3.016228137534469,0,11.248593925759279,0},
{1.0463808303031887,2.6570926754456448,0,3.803532072579844,0}}));
        e.AddChange(new Int2(3,3),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0.9667907094734309,0.894691575511001,1.0246971898342088,0.891824447508959,1.0034100499964045},
{1.0064990413738828,0.8408397639237088,1.0524002811011621,0.9255664384694899,1.0471594617999485},
{1.0024113401126975,0.7104630716324392,1.097574360662935,0.5318777714136911,1.097574360662935},
{1.0296155369929134,0.8032678285294542,1.097574360662935,0,1.097574360662935},
{0.9954744201361503,0.838310241634159,1.097574360662935,0.7264471504199888,1.097574360662935}}));
        e.AddChange(new Int2(3,4),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.8661081640184725,0.8691157146926437,0.8570563475152843,1.174224351229177,0.6078092576823552},
{0.9941433958328728,0.8871961279081637,0.9343674573901559,0.49798955355087426,0.4754863554343674},
{0.9604455601645421,0.6963712096266356,1.0486258752145405,0,1.1575123125073123},
{0.9812410440977865,0.7224958368020507,1.1733072393893254,0,2.397506593143131},
{0.8834665768199078,0.8066798499485347,1.1472827354929438,0,1.5579416614808212}}));
        e.AddChange(new Int2(3,4),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0958076596121036,1.0936555762595612,1.102284778609324,0.8753320005186314,1.2806360587076508},
{1.0041907524414286,1.0807179534216933,1.0469640307472396,1.3592186605145486,1.3753210518928212},
{1.02830358012587,1.2172646568274665,0.9652052623915167,1.7155601303825698,0.8872904691254077},
{1.0134231609312288,1.1985709151996307,0.8759882491863311,1.7155601303825696,0},
{1.0833866714846738,1.1383321917764047,0.8946103465875676,1.71556013038257,0.6007591919649156}}));
        e.AddChange(new Int2(4,0),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.9575096132469062,1.329120653775462,0.6823889070859264,0.9100577831869565,0.7782487493794632},
{0.6054156227337821,1.003941756301876,0.8117829708836316,1.3877181093425452,0.9266029767865753},
{1.0903408299212018,0.6011925822791402,0.8916665096600912,1.0004001600640255,0.8715901827657567},
{1.5361709010975977,0,1.0449482307851088,1.0463808303031887,0.8834665768199078},
{2.768549280177187,0,0.971850632274588,0.837325799828166,0.7790189212966979}}));
        e.AddChange(new Int2(4,0),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0240255599486812,0.813903600275991,1.179588488980218,1.050856494541126,1.1253859607453631},
{1.2231118927184688,0.99777119227264,1.1064245318046841,0.7807705367962942,1.0415012598382734},
{0.9489181155799342,1.2254997484044685,1.0612555678002114,0.9997737354177738,1.0726074295319485},
{0.6968301041383026,1.5654351909830935,0.97458468854167,0.973774646359562,1.065892098391749},
{0,1.5654351909830935,1.0159166431158717,1.0919817174421829,1.1249504784402513}}));
        e.AddChange(new Int2(4,1),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{1.301890229491589,1.2891471002784556,1.033771551615457,1.3399836224223927,0.9039840981764757},
{1.1361145179734204,1.9076155735874338,1.0244174159497523,1.878140625194828,0.9083714069863655},
{0.7317994063586652,3.717800725881093,0.6366341183772285,2.141207360137037,0.7947988364145034},
{0,4.007558872581207,0,2.6570926754456443,0.8066798499485347},
{0,6.265664160401003,0,1.7812219967577052,0.7829880795783336}}));
        e.AddChange(new Int2(4,1),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{0.9426681572740866,0.9450881994235583,0.993586459260082,0.9354338575218779,1.018234338328218},
{0.9741505508465518,0.8276351195328957,0.9953628991128267,0.8332326942157371,1.0174011464123942},
{1.0509338585734853,0.4838636413010204,1.0690066571953762,0.7832738045241894,1.0389696640983404},
{1.1899095668729176,0.4288357971633024,1.1899095668729178,0.6853022477378332,1.0367133459640812},
{1.1899095668729176,0,1.1899095668729178,0.8516384689641483,1.0412126398135386}}));
        e.AddChange(new Int2(4,2),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.7084817934791514,0.9997685760533802,1.0134004068110178,0.9627314747207267,0.7070604324189921},
{0.8755800717975659,0.7747824929985625,0.7210192365141259,0.8030969374693233,0.8617458547593619},
{0.9721265968967032,0.3264013839418679,1.164823086297901,0.41773510453017654,0.9732680128758633},
{1.1110821195466376,0,1.6430957716112127,0,1.1472827354929436},
{0.9718506322745878,0,3.2776138970829236,0,0.953554618752572}}));
        e.AddChange(new Int2(4,2),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.1279928116412592,1.0001016080675114,0.9941164712648702,1.0163629688627231,1.1286168687134344},
{1.0546273134185677,1.0988830930869746,1.1224881723119013,1.0864514669421634,1.060701309127815},
{1.012237984295317,1.295747500013435,0.9276334384379197,1.2556468838794692,1.011736838784824},
{0.9512287312222202,1.4390559792775939,0.7176449562259593,1.4390559792775939,0.9353346343374627},
{1.0123591482127259,1.4390559792775939,0,1.4390559792775939,1.0203921223465107}}));
        e.AddChange(new Int2(4,3),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.9762292409589245,1.4192188406822557,0.9764283887419695,1.2399486661252224,1.3041694556603978},
{0.8807885944538444,2.0381656199433347,0.9935603426165758,1.8224469387564368,1.190929164432114},
{0.7725600792062511,2.373052516345049,0.5962858052610459,3.516747964057257,0.7293128777518775},
{0.7933833623916227,2.657196265137354,0,3.803532072579844,0},
{0.8373257998281661,1.7812219967577052,0,6.261740763932373,0}}));
        e.AddChange(new Int2(4,3),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.0045176606198498,0.9203269679198426,1.0044798123502408,0.9543974747349779,0.9421922384041825},
{1.0226562673637047,0.8026954069916096,1.0012238644342888,0.8436929952167048,0.963713688492433},
{1.0432252235520194,0.7390497597759083,1.0767263559440805,0.5216890992979365,1.05144440488281},
{1.0392677341735783,0.6850479072445134,1.1900511722004048,0.46718544330477074,1.1900511722004046},
{1.0309164224294203,0.8515278437674575,1.1900511722004048,0,1.1900511722004046}}));
        e.AddChange(new Int2(4,4),SlavekTile.Boat, new CoefficientMap(s, new double[,] 
{{0.751938974423528,0.8730915566727213,0.6818030715416716,1.288250139251499,0.9605980497535563},
{0.920797475673885,1.2685556676981937,0.8250033896878401,0.9465450059447218,0.6086672605539275},
{0.8635333662162614,0.8661529563975494,0.9230165694413699,0.5427613336825884,1.0891692267270903},
{0.9324861874224732,1.101864430607238,1.1154408616690834,0,1.5579416614808212},
{0.7790189212966979,0.7829880795783337,0.9535546187525721,0,2.808199943836001}}));
        e.AddChange(new Int2(4,4),SlavekTile.Water, new CoefficientMap(s, new double[,] 
{{1.1371867234163406,1.070184961436316,1.1759744156297727,0.8405872424484255,1.0217907042751337},
{1.043801861954542,0.8514789978764921,1.0967794578850134,1.0295625460212527,1.2164211655796653},
{1.0754709866289631,1.0740222584668933,1.0425746228015658,1.252869527994456,0.9506861909651859},
{1.0373375813928518,0.9436652838340777,0.9361570261836301,1.5530361857431276,0.691438071667463},
{1.122210532887476,1.1200154447307897,1.025685976490463,1.5530361857431276,0}}));
        return e;
    }
}