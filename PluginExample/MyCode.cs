using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Hearthstone_Deck_Tracker;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Enums;
using Hearthstone_Deck_Tracker.Hearthstone;
using Hearthstone_Deck_Tracker.Hearthstone.Entities;
using System.Text;
using System.Collections;
using System.Windows.Input;
using Hearthstone_Deck_Tracker.Utility.HotKeys;

namespace PluginExample
{
	public class MyCode
	{
		private static HearthstoneTextBlock _info;
		private static int? _opponent;
        public static String URLToOpen;
        private static ArrayList OpponentCards = new ArrayList();
		private static Entity[] Entities
		{
			// Get the Game.Entities
			get { 
				return Helper.DeepClone<Dictionary<int, Entity>>(
					Hearthstone_Deck_Tracker.API.Core.Game.Entities).Values.ToArray<Entity>();
			}
		}

		private static Entity PlayerEntity
		{
			// Get the Entity representing the player, there is also the equivalent for the Opponent
			//get { return Entities == null ? null : Entities.First(x => x.IsPlayer); }
            get { return Entities == null ? null : Entities.First(x => x.IsOpponent); }
        }		

        private static void SetUpCardDatabase(String CardName)
        {
            switch (CardName)
            {
                case "abomination":
                    OpponentCards.Add("29476");
                    break;
                case "abusivesergeant":
                    OpponentCards.Add("29407");
                    break;
                case "acidicswampooze":
                    OpponentCards.Add("29321");
                    break;
                case "acidmaw":
                    OpponentCards.Add("30998");
                    break;
                case "acolyteofpain":
                    OpponentCards.Add("29430");
                    break;
                case "alakirthewindlord":
                    OpponentCards.Add("29729");
                    break;
                case "alarmobot":
                    OpponentCards.Add("29429");
                    break;
                case "aldorpeacekeeper":
                    OpponentCards.Add("29602");
                    break;
                case "alexstrasza":
                    OpponentCards.Add("29653");
                    break;
                case "alexstraszaschampion":
                    OpponentCards.Add("31011");
                    break;
                case "alleriawindrunner":
                    OpponentCards.Add("29823");
                    break;
                case "amaniberserker":
                    OpponentCards.Add("29610");
                    break;
                case "ancestorscall":
                    OpponentCards.Add("30543");
                    break;
                case "ancestralhealing":
                    OpponentCards.Add("29208");
                    break;
                case "ancestralknowledge":
                    OpponentCards.Add("30986");
                    break;
                case "ancestralspirit":
                    OpponentCards.Add("29388");
                    break;
                case "ancientbrewmaster":
                    OpponentCards.Add("29459");
                    break;
                case "ancientmage":
                    OpponentCards.Add("29672");
                    break;
                case "ancientoflore":
                    OpponentCards.Add("29726");
                    break;
                case "ancientofwar":
                    OpponentCards.Add("29533");
                    break;
                case "ancientshade":
                    OpponentCards.Add("30215");
                    break;
                case "ancientwatcher":
                    OpponentCards.Add("29451");
                    break;
                case "angrychicken":
                    OpponentCards.Add("29432");
                    break;
                case "animagolem":
                    OpponentCards.Add("30615");
                    break;
                case "animalcompanion":
                    OpponentCards.Add("29377");
                    break;
                case "animatedarmor":
                    OpponentCards.Add("30226");
                    break;
                case "annoyotron":
                    OpponentCards.Add("30624");
                    break;
                case "anodizedrobocub":
                    OpponentCards.Add("30544");
                    break;
                case "antiquehealbot":
                    OpponentCards.Add("30605");
                    break;
                case "anubarambusher":
                    OpponentCards.Add("30378");
                    break;
                case "anubarak":
                    OpponentCards.Add("30953");
                    break;
                case "anubisathsentinel":
                    OpponentCards.Add("30198");
                    break;
                case "anyfincanhappen":
                    OpponentCards.Add("30187");
                    break;
                case "arathiweaponsmith":
                    OpponentCards.Add("29612");
                    break;
                case "arcaneblast":
                    OpponentCards.Add("30906");
                    break;
                case "arcaneexplosion":
                    OpponentCards.Add("29199");
                    break;
                case "arcanegolem":
                    OpponentCards.Add("29470");
                    break;
                case "arcaneintellect":
                    OpponentCards.Add("29197");
                    break;
                case "arcanemissiles":
                    OpponentCards.Add("29331");
                    break;
                case "arcanenullifierx21":
                    OpponentCards.Add("30631");
                    break;
                case "arcaneshot":
                    OpponentCards.Add("29313");
                    break;
                case "arcanitereaper":
                    OpponentCards.Add("29258");
                    break;
                case "archmage":
                    OpponentCards.Add("29274");
                    break;
                case "archmageantonidas":
                    OpponentCards.Add("29651");
                    break;
                case "archthiefrafaam":
                    OpponentCards.Add("30210");
                    break;
                case "argentcommander":
                    OpponentCards.Add("29463");
                    break;
                case "argenthorserider":
                    OpponentCards.Add("31037");
                    break;
                case "argentlance":
                    OpponentCards.Add("31021");
                    break;
                case "argentprotector":
                    OpponentCards.Add("29593");
                    break;
                case "argentsquire":
                    OpponentCards.Add("29431");
                    break;
                case "argentwatchman":
                    OpponentCards.Add("31062");
                    break;
                case "armoredwarhorse":
                    OpponentCards.Add("31061");
                    break;
                case "armorsmith":
                    OpponentCards.Add("29614");
                    break;
                case "assassinate":
                    OpponentCards.Add("29231");
                    break;
                case "assassinsblade":
                    OpponentCards.Add("29233");
                    break;
                case "astralcommunion":
                    OpponentCards.Add("30971");
                    break;
                case "auchenaisoulpriest":
                    OpponentCards.Add("29677");
                    break;
                case "avenge":
                    OpponentCards.Add("30370");
                    break;
                case "avengingwrath":
                    OpponentCards.Add("29606");
                    break;
                case "aviana":
                    OpponentCards.Add("30973");
                    break;
                case "axeflinger":
                    OpponentCards.Add("30877");
                    break;
                case "azuredrake":
                    OpponentCards.Add("29555");
                    break;
                case "backstab":
                    OpponentCards.Add("29227");
                    break;
                case "ballofspiders":
                    OpponentCards.Add("30997");
                    break;
                case "baneofdoom":
                    OpponentCards.Add("29576");
                    break;
                case "barongeddon":
                    OpponentCards.Add("29544");
                    break;
                case "baronrivendare":
                    OpponentCards.Add("30385");
                    break;
                case "bash":
                    OpponentCards.Add("31000");
                    break;
                case "battlerage":
                    OpponentCards.Add("29609");
                    break;
                case "beartrap":
                    OpponentCards.Add("30994");
                    break;
                case "beneaththegrounds":
                    OpponentCards.Add("30951");
                    break;
                case "bestialwrath":
                    OpponentCards.Add("29644");
                    break;
                case "betrayal":
                    OpponentCards.Add("29487");
                    break;
                case "biggamehunter":
                    OpponentCards.Add("29428");
                    break;
                case "bite":
                    OpponentCards.Add("29659");
                    break;
                case "blackwingcorruptor":
                    OpponentCards.Add("30902");
                    break;
                case "blackwingtechnician":
                    OpponentCards.Add("30900");
                    break;
                case "bladeflurry":
                    OpponentCards.Add("29414");
                    break;
                case "blessedchampion":
                    OpponentCards.Add("29591");
                    break;
                case "blessingofkings":
                    OpponentCards.Add("29244");
                    break;
                case "blessingofmight":
                    OpponentCards.Add("29239");
                    break;
                case "blessingofwisdom":
                    OpponentCards.Add("29594");
                    break;
                case "blingtron3000":
                    OpponentCards.Add("30667");
                    break;
                case "blizzard":
                    OpponentCards.Add("29386");
                    break;
                case "bloodimp":
                    OpponentCards.Add("29392");
                    break;
                case "bloodknight":
                    OpponentCards.Add("29675");
                    break;
                case "bloodfenraptor":
                    OpponentCards.Add("29278");
                    break;
                case "bloodlust":
                    OpponentCards.Add("29213");
                    break;
                case "bloodmagethalnos":
                    OpponentCards.Add("29434");
                    break;
                case "bloodsailcorsair":
                    OpponentCards.Add("29745");
                    break;
                case "bloodsailraider":
                    OpponentCards.Add("29736");
                    break;
                case "bluegillwarrior":
                    OpponentCards.Add("29279");
                    break;
                case "bolframshield":
                    OpponentCards.Add("31083");
                    break;
                case "bolster":
                    OpponentCards.Add("31006");
                    break;
                case "bolvarfordragon":
                    OpponentCards.Add("30596");
                    break;
                case "bomblobber":
                    OpponentCards.Add("30640");
                    break;
                case "boneguardlieutenant":
                    OpponentCards.Add("31039");
                    break;
                case "bootybaybodyguard":
                    OpponentCards.Add("29283");
                    break;
                case "boulderfistogre":
                    OpponentCards.Add("29287");
                    break;
                case "bouncingblade":
                    OpponentCards.Add("30579");
                    break;
                case "brannbronzebeard":
                    OpponentCards.Add("30203");
                    break;
                case "bravearcher":
                    OpponentCards.Add("30993");
                    break;
                case "brawl":
                    OpponentCards.Add("29616");
                    break;
                case "buccaneer":
                    OpponentCards.Add("30942");
                    break;
                case "burgle":
                    OpponentCards.Add("30948");
                    break;
                case "burlyrockjawtrogg":
                    OpponentCards.Add("30603");
                    break;
                case "cabalshadowpriest":
                    OpponentCards.Add("29471");
                    break;
                case "cairnebloodhoof":
                    OpponentCards.Add("29482");
                    break;
                case "callpet":
                    OpponentCards.Add("30524");
                    break;
                case "captaingreenskin":
                    OpponentCards.Add("29743");
                    break;
                case "captainsparrot":
                    OpponentCards.Add("30228");
                    break;
                case "capturedjormungar":
                    OpponentCards.Add("31056");
                    break;
                case "cenarius":
                    OpponentCards.Add("29663");
                    break;
                case "charge":
                    OpponentCards.Add("29252");
                    break;
                case "chargedhammer":
                    OpponentCards.Add("30982");
                    break;
                case "chillmaw":
                    OpponentCards.Add("31082");
                    break;
                case "chillwindyeti":
                    OpponentCards.Add("29281");
                    break;
                case "chromaggus":
                    OpponentCards.Add("30899");
                    break;
                case "circleofhealing":
                    OpponentCards.Add("29706");
                    break;
                case "claw":
                    OpponentCards.Add("29182");
                    break;
                case "cleave":
                    OpponentCards.Add("29259");
                    break;
                case "clockworkgiant":
                    OpponentCards.Add("30669");
                    break;
                case "clockworkgnome":
                    OpponentCards.Add("30621");
                    break;
                case "clockworkknight":
                    OpponentCards.Add("31048");
                    break;
                case "cobaltguardian":
                    OpponentCards.Add("30595");
                    break;
                case "cobrashot":
                    OpponentCards.Add("30610");
                    break;
                case "coghammer":
                    OpponentCards.Add("30591");
                    break;
                case "cogmaster":
                    OpponentCards.Add("30519");
                    break;
                case "cogmasterswrench":
                    OpponentCards.Add("30536");
                    break;
                case "coldblood":
                    OpponentCards.Add("29394");
                    break;
                case "coldarradrake":
                    OpponentCards.Add("30912");
                    break;
                case "coldlightoracle":
                    OpponentCards.Add("29456");
                    break;
                case "coldlightseer":
                    OpponentCards.Add("29479");
                    break;
                case "coliseummanager":
                    OpponentCards.Add("31064");
                    break;
                case "commandingshout":
                    OpponentCards.Add("29754");
                    break;
                case "competitivespirit":
                    OpponentCards.Add("31014");
                    break;
                case "conceal":
                    OpponentCards.Add("29488");
                    break;
                case "coneofcold":
                    OpponentCards.Add("29552");
                    break;
                case "confessorpaletress":
                    OpponentCards.Add("30927");
                    break;
                case "confuse":
                    OpponentCards.Add("30923");
                    break;
                case "consecration":
                    OpponentCards.Add("29246");
                    break;
                case "convert":
                    OpponentCards.Add("30922");
                    break;
                case "corehound":
                    OpponentCards.Add("29288");
                    break;
                case "corerager":
                    OpponentCards.Add("30874");
                    break;
                case "corruption":
                    OpponentCards.Add("29223");
                    break;
                case "counterspell":
                    OpponentCards.Add("29556");
                    break;
                case "crackle":
                    OpponentCards.Add("30559");
                    break;
                case "crazedalchemist":
                    OpponentCards.Add("29461");
                    break;
                case "crowdfavorite":
                    OpponentCards.Add("31079");
                    break;
                case "crueltaskmaster":
                    OpponentCards.Add("29684");
                    break;
                case "crush":
                    OpponentCards.Add("30581");
                    break;
                case "cultmaster":
                    OpponentCards.Add("29679");
                    break;
                case "curseofrafaam":
                    OpponentCards.Add("30162");
                    break;
                case "cursedblade":
                    OpponentCards.Add("30224");
                    break;
                case "cutpurse":
                    OpponentCards.Add("30945");
                    break;
                case "dalaranaspirant":
                    OpponentCards.Add("30909");
                    break;
                case "dalaranmage":
                    OpponentCards.Add("29350");
                    break;
                case "dancingswords":
                    OpponentCards.Add("30382");
                    break;
                case "darkbargain":
                    OpponentCards.Add("30936");
                    break;
                case "darkcultist":
                    OpponentCards.Add("30374");
                    break;
                case "darkirondwarf":
                    OpponentCards.Add("29452");
                    break;
                case "darkironskulker":
                    OpponentCards.Add("30862");
                    break;
                case "darkpeddler":
                    OpponentCards.Add("30185");
                    break;
                case "darkwispers":
                    OpponentCards.Add("30562");
                    break;
                case "darkbomb":
                    OpponentCards.Add("30522");
                    break;
                case "darkscalehealer":
                    OpponentCards.Add("29304");
                    break;
                case "darnassusaspirant":
                    OpponentCards.Add("30959");
                    break;
                case "darttrap":
                    OpponentCards.Add("30183");
                    break;
                case "deadlypoison":
                    OpponentCards.Add("29228");
                    break;
                case "deadlyshot":
                    OpponentCards.Add("29702");
                    break;
                case "deathlord":
                    OpponentCards.Add("30356");
                    break;
                case "deathsbite":
                    OpponentCards.Add("30372");
                    break;
                case "deathwing":
                    OpponentCards.Add("29753");
                    break;
                case "defenderofargus":
                    OpponentCards.Add("29472");
                    break;
                case "defiasringleader":
                    OpponentCards.Add("29492");
                    break;
                case "demolisher":
                    OpponentCards.Add("29478");
                    break;
                case "demonfire":
                    OpponentCards.Add("29680");
                    break;
                case "demonfuse":
                    OpponentCards.Add("30934");
                    break;
                case "demonheart":
                    OpponentCards.Add("30526");
                    break;
                case "demonwrath":
                    OpponentCards.Add("30858");
                    break;
                case "desertcamel":
                    OpponentCards.Add("30182");
                    break;
                case "direwolfalpha":
                    OpponentCards.Add("29519");
                    break;
                case "divinefavor":
                    OpponentCards.Add("29588");
                    break;
                case "divinespirit":
                    OpponentCards.Add("29297");
                    break;
                case "djinniofzephyrs":
                    OpponentCards.Add("30197");
                    break;
                case "doomguard":
                    OpponentCards.Add("29567");
                    break;
                case "doomhammer":
                    OpponentCards.Add("29658");
                    break;
                case "doomsayer":
                    OpponentCards.Add("29740");
                    break;
                case "dr.boom":
                    OpponentCards.Add("30656");
                    break;
                case "draeneitotemcarver":
                    OpponentCards.Add("30977");
                    break;
                case "dragonconsort":
                    OpponentCards.Add("30879");
                    break;
                case "dragonegg":
                    OpponentCards.Add("30884");
                    break;
                case "dragonhawkrider":
                    OpponentCards.Add("31030");
                    break;
                case "dragonkinsorcerer":
                    OpponentCards.Add("30882");
                    break;
                case "dragonlingmechanic":
                    OpponentCards.Add("29319");
                    break;
                case "dragonsbreath":
                    OpponentCards.Add("30853");
                    break;
                case "drainlife":
                    OpponentCards.Add("29221");
                    break;
                case "drakonidcrusher":
                    OpponentCards.Add("30886");
                    break;
                case "dreadcorsair":
                    OpponentCards.Add("29741");
                    break;
                case "dreadinfernal":
                    OpponentCards.Add("29225");
                    break;
                case "dreadscale":
                    OpponentCards.Add("30999");
                    break;
                case "dreadsteed":
                    OpponentCards.Add("30928");
                    break;
                case "druidoftheclaw":
                    OpponentCards.Add("29524");
                    break;
                case "druidofthefang":
                    OpponentCards.Add("30618");
                    break;
                case "druidoftheflame":
                    OpponentCards.Add("30864");
                    break;
                case "druidofthesaber":
                    OpponentCards.Add("30966");
                    break;
                case "dunemaulshaman":
                    OpponentCards.Add("30600");
                    break;
                case "duplicate":
                    OpponentCards.Add("30367");
                    break;
                case "dustdevil":
                    OpponentCards.Add("29540");
                    break;
                case "eadricthepure":
                    OpponentCards.Add("31026");
                    break;
                case "eaglehornbow":
                    OpponentCards.Add("29637");
                    break;
                case "earthelemental":
                    OpponentCards.Add("29545");
                    break;
                case "earthshock":
                    OpponentCards.Add("29541");
                    break;
                case "earthenringfarseer":
                    OpponentCards.Add("29399");
                    break;
                case "echoofmedivh":
                    OpponentCards.Add("30509");
                    break;
                case "echoingooze":
                    OpponentCards.Add("30348");
                    break;
                case "edwinvancleef":
                    OpponentCards.Add("29697");
                    break;
                case "eeriestatue":
                    OpponentCards.Add("30214");
                    break;
                case "effigy":
                    OpponentCards.Add("30904");
                    break;
                case "elementaldestruction":
                    OpponentCards.Add("30984");
                    break;
                case "elisestarseeker":
                    OpponentCards.Add("30204");
                    break;
                case "elitetaurenchieftain":
                    OpponentCards.Add("30340");
                    break;
                case "elvenarcher":
                    OpponentCards.Add("29284");
                    break;
                case "emperorcobra":
                    OpponentCards.Add("29532");
                    break;
                case "emperorthaurissan":
                    OpponentCards.Add("30894");
                    break;
                case "enhance-omechano":
                    OpponentCards.Add("30653");
                    break;
                case "enterthecoliseum":
                    OpponentCards.Add("31023");
                    break;
                case "entomb":
                    OpponentCards.Add("30211");
                    break;
                case "equality":
                    OpponentCards.Add("29703");
                    break;
                case "etherealarcanist":
                    OpponentCards.Add("29550");
                    break;
                case "etherealconjurer":
                    OpponentCards.Add("30160");
                    break;
                case "everyfinisawesome":
                    OpponentCards.Add("30218");
                    break;
                case "evilheckler":
                    OpponentCards.Add("31068");
                    break;
                case "eviscerate":
                    OpponentCards.Add("29486");
                    break;
                case "excavatedevil":
                    OpponentCards.Add("30217");
                    break;
                case "execute":
                    OpponentCards.Add("29257");
                    break;
                case "explorershat":
                    OpponentCards.Add("30212");
                    break;
                case "explosivesheep":
                    OpponentCards.Add("30613");
                    break;
                case "explosiveshot":
                    OpponentCards.Add("29639");
                    break;
                case "explosivetrap":
                    OpponentCards.Add("29692");
                    break;
                case "eydisdarkbane":
                    OpponentCards.Add("31089");
                    break;
                case "eyeforaneye":
                    OpponentCards.Add("29494");
                    break;
                case "facelessmanipulator":
                    OpponentCards.Add("29657");
                    break;
                case "faeriedragon":
                    OpponentCards.Add("29742");
                    break;
                case "fallenhero":
                    OpponentCards.Add("30905");
                    break;
                case "fanofknives":
                    OpponentCards.Add("29324");
                    break;
                case "farsight":
                    OpponentCards.Add("29390");
                    break;
                case "fearsomedoomguard":
                    OpponentCards.Add("30929");
                    break;
                case "feigndeath":
                    OpponentCards.Add("30538");
                    break;
                case "felcannon":
                    OpponentCards.Add("30528");
                    break;
                case "felreaver":
                    OpponentCards.Add("30523");
                    break;
                case "felguard":
                    OpponentCards.Add("29562");
                    break;
                case "fencreeper":
                    OpponentCards.Add("29383");
                    break;
                case "fencingcoach":
                    OpponentCards.Add("31069");
                    break;
                case "feralspirit":
                    OpponentCards.Add("29543");
                    break;
                case "feugen":
                    OpponentCards.Add("30364");
                    break;
                case "fiercemonkey":
                    OpponentCards.Add("30184");
                    break;
                case "fierywaraxe":
                    OpponentCards.Add("29256");
                    break;
                case "fireelemental":
                    OpponentCards.Add("29210");
                    break;
                case "fireball":
                    OpponentCards.Add("29202");
                    break;
                case "fireguarddestroyer":
                    OpponentCards.Add("30871");
                    break;
                case "fistofjaraxxus":
                    OpponentCards.Add("30932");
                    break;
                case "fjolalightbane":
                    OpponentCards.Add("31087");
                    break;
                case "flameimp":
                    OpponentCards.Add("29575");
                    break;
                case "flamejuggler":
                    OpponentCards.Add("31046");
                    break;
                case "flamelance":
                    OpponentCards.Add("30903");
                    break;
                case "flameleviathan":
                    OpponentCards.Add("30511");
                    break;
                case "flamecannon":
                    OpponentCards.Add("30505");
                    break;
                case "flamestrike":
                    OpponentCards.Add("29203");
                    break;
                case "flametonguetotem":
                    OpponentCards.Add("29347");
                    break;
                case "flamewaker":
                    OpponentCards.Add("30852");
                    break;
                case "flare":
                    OpponentCards.Add("29643");
                    break;
                case "flashheal":
                    OpponentCards.Add("30988");
                    break;
                case "flesheatingghoul":
                    OpponentCards.Add("29765");
                    break;
                case "floatingwatcher":
                    OpponentCards.Add("30641");
                    break;
                case "flyingmachine":
                    OpponentCards.Add("30623");
                    break;
                case "foereaper4000":
                    OpponentCards.Add("30661");
                    break;
                case "forceofnature":
                    OpponentCards.Add("29661");
                    break;
                case "force-tankmax":
                    OpponentCards.Add("30617");
                    break;
                case "forgottentorch":
                    OpponentCards.Add("30158");
                    break;
                case "forkedlightning":
                    OpponentCards.Add("29546");
                    break;
                case "fossilizeddevilsaur":
                    OpponentCards.Add("30200");
                    break;
                case "freezingtrap":
                    OpponentCards.Add("29693");
                    break;
                case "frigidsnobold":
                    OpponentCards.Add("31045");
                    break;
                case "frostelemental":
                    OpponentCards.Add("29554");
                    break;
                case "frostgiant":
                    OpponentCards.Add("31078");
                    break;
                case "frostnova":
                    OpponentCards.Add("29200");
                    break;
                case "frostshock":
                    OpponentCards.Add("29206");
                    break;
                case "frostbolt":
                    OpponentCards.Add("29198");
                    break;
                case "frostwolfgrunt":
                    OpponentCards.Add("29263");
                    break;
                case "frostwolfwarlord":
                    OpponentCards.Add("29292");
                    break;
                case "frothingberserker":
                    OpponentCards.Add("29686");
                    break;
                case "gadgetzanauctioneer":
                    OpponentCards.Add("29474");
                    break;
                case "gadgetzanjouster":
                    OpponentCards.Add("31106");
                    break;
                case "gahzrilla":
                    OpponentCards.Add("30577");
                    break;
                case "gangup":
                    OpponentCards.Add("30861");
                    break;
                case "garrisoncommander":
                    OpponentCards.Add("31025");
                    break;
                case "gazlowe":
                    OpponentCards.Add("30665");
                    break;
                case "gelbinmekkatorque":
                    OpponentCards.Add("30332");
                    break;
                case "gilblinstalker":
                    OpponentCards.Add("30620");
                    break;
                case "gladiatorslongbow":
                    OpponentCards.Add("29421");
                    break;
                case "glaivezooka":
                    OpponentCards.Add("30567");
                    break;
                case "gnomereganinfantry":
                    OpponentCards.Add("30639");
                    break;
                case "gnomishexperimenter":
                    OpponentCards.Add("30632");
                    break;
                case "gnomishinventor":
                    OpponentCards.Add("29272");
                    break;
                case "goblinauto-barber":
                    OpponentCards.Add("30534");
                    break;
                case "goblinblastmage":
                    OpponentCards.Add("30508");
                    break;
                case "goblinsapper":
                    OpponentCards.Add("30636");
                    break;
                case "goldshirefootman":
                    OpponentCards.Add("29174");
                    break;
                case "gorehowl":
                    OpponentCards.Add("29622");
                    break;
                case "gorillabota-3":
                    OpponentCards.Add("30192");
                    break;
                case "gormoktheimpaler":
                    OpponentCards.Add("31081");
                    break;
                case "grandcrusader":
                    OpponentCards.Add("31075");
                    break;
                case "grimpatron":
                    OpponentCards.Add("30881");
                    break;
                case "grimscaleoracle":
                    OpponentCards.Add("29344");
                    break;
                case "grommashhellscream":
                    OpponentCards.Add("29626");
                    break;
                case "grovetender":
                    OpponentCards.Add("30550");
                    break;
                case "gruul":
                    OpponentCards.Add("29759");
                    break;
                case "guardianofkings":
                    OpponentCards.Add("29241");
                    break;
                case "gurubashiberserker":
                    OpponentCards.Add("29339");
                    break;
                case "hammerofwrath":
                    OpponentCards.Add("29247");
                    break;
                case "handofprotection":
                    OpponentCards.Add("29338");
                    break;
                case "harrisonjones":
                    OpponentCards.Add("29650");
                    break;
                case "harvestgolem":
                    OpponentCards.Add("29648");
                    break;
                case "hauntedcreeper":
                    OpponentCards.Add("30346");
                    break;
                case "headcrack":
                    OpponentCards.Add("29498");
                    break;
                case "healingtouch":
                    OpponentCards.Add("29184");
                    break;
                case "healingwave":
                    OpponentCards.Add("30979");
                    break;
                case "hellfire":
                    OpponentCards.Add("29222");
                    break;
                case "hemetnesingwary":
                    OpponentCards.Add("30668");
                    break;
                case "heroicstrike":
                    OpponentCards.Add("29254");
                    break;
                case "hex":
                    OpponentCards.Add("29329");
                    break;
                case "hobgoblin":
                    OpponentCards.Add("30648");
                    break;
                case "hogger":
                    OpponentCards.Add("29761");
                    break;
                case "holychampion":
                    OpponentCards.Add("30915");
                    break;
                case "holyfire":
                    OpponentCards.Add("29709");
                    break;
                case "holylight":
                    OpponentCards.Add("29242");
                    break;
                case "holynova":
                    OpponentCards.Add("29175");
                    break;
                case "holysmite":
                    OpponentCards.Add("29178");
                    break;
                case "holywrath":
                    OpponentCards.Add("29597");
                    break;
                case "houndmaster":
                    OpponentCards.Add("29305");
                    break;
                case "hugetoad":
                    OpponentCards.Add("30193");
                    break;
                case "humility":
                    OpponentCards.Add("29336");
                    break;
                case "hungrycrab":
                    OpponentCards.Add("29734");
                    break;
                case "hungrydragon":
                    OpponentCards.Add("30889");
                    break;
                case "huntersmark":
                    OpponentCards.Add("29237");
                    break;
                case "icebarrier":
                    OpponentCards.Add("29557");
                    break;
                case "iceblock":
                    OpponentCards.Add("29559");
                    break;
                case "icelance":
                    OpponentCards.Add("29387");
                    break;
                case "icerager":
                    OpponentCards.Add("31044");
                    break;
                case "icehowl":
                    OpponentCards.Add("31084");
                    break;
                case "illidanstormrage":
                    OpponentCards.Add("29699");
                    break;
                case "illuminator":
                    OpponentCards.Add("30629");
                    break;
                case "impgangboss":
                    OpponentCards.Add("30859");
                    break;
                case "impmaster":
                    OpponentCards.Add("29682");
                    break;
                case "imp-losion":
                    OpponentCards.Add("30570");
                    break;
                case "injuredblademaster":
                    OpponentCards.Add("29405");
                    break;
                case "injuredkvaldir":
                    OpponentCards.Add("31059");
                    break;
                case "innerfire":
                    OpponentCards.Add("29384");
                    break;
                case "innerrage":
                    OpponentCards.Add("29688");
                    break;
                case "innervate":
                    OpponentCards.Add("29325");
                    break;
                case "ironjuggernaut":
                    OpponentCards.Add("30586");
                    break;
                case "ironsensei":
                    OpponentCards.Add("30539");
                    break;
                case "ironbarkprotector":
                    OpponentCards.Add("29294");
                    break;
                case "ironbeakowl":
                    OpponentCards.Add("29409");
                    break;
                case "ironforgerifleman":
                    OpponentCards.Add("29270");
                    break;
                case "ironfurgrizzly":
                    OpponentCards.Add("29267");
                    break;
                case "jeeves":
                    OpponentCards.Add("30635");
                    break;
                case "jeweledscarab":
                    OpponentCards.Add("30189");
                    break;
                case "junglemoonkin":
                    OpponentCards.Add("30196");
                    break;
                case "junglepanther":
                    OpponentCards.Add("29439");
                    break;
                case "junkbot":
                    OpponentCards.Add("30651");
                    break;
                case "justicartrueheart":
                    OpponentCards.Add("31090");
                    break;
                case "keeperofthegrove":
                    OpponentCards.Add("29529");
                    break;
                case "keeperofuldaman":
                    OpponentCards.Add("30174");
                    break;
                case "kelthuzad":
                    OpponentCards.Add("30361");
                    break;
                case "kezanmystic":
                    OpponentCards.Add("30611");
                    break;
                case "kidnapper":
                    OpponentCards.Add("29722");
                    break;
                case "killcommand":
                    OpponentCards.Add("29346");
                    break;
                case "kingkrush":
                    OpponentCards.Add("29642");
                    break;
                case "kingmukla":
                    OpponentCards.Add("29435");
                    break;
                case "kingofbeasts":
                    OpponentCards.Add("30572");
                    break;
                case "kingsdefender":
                    OpponentCards.Add("31001");
                    break;
                case "kingselekk":
                    OpponentCards.Add("30992");
                    break;
                case "kirintormage":
                    OpponentCards.Add("29695");
                    break;
                case "knifejuggler":
                    OpponentCards.Add("29738");
                    break;
                case "knightofthewild":
                    OpponentCards.Add("30964");
                    break;
                case "koboldgeomancer":
                    OpponentCards.Add("29271");
                    break;
                case "kodorider":
                    OpponentCards.Add("31052");
                    break;
                case "korkronelite":
                    OpponentCards.Add("29376");
                    break;
                case "kvaldirraider":
                    OpponentCards.Add("31076");
                    break;
                case "lancecarrier":
                    OpponentCards.Add("31032");
                    break;
                case "lavaburst":
                    OpponentCards.Add("29539");
                    break;
                case "lavashock":
                    OpponentCards.Add("30869");
                    break;
                case "layonhands":
                    OpponentCards.Add("29590");
                    break;
                case "leeroyjenkins":
                    OpponentCards.Add("29484");
                    break;
                case "lepergnome":
                    OpponentCards.Add("29444");
                    break;
                case "lightofthenaaru":
                    OpponentCards.Add("30518");
                    break;
                case "lightbomb":
                    OpponentCards.Add("30512");
                    break;
                case "lightningbolt":
                    OpponentCards.Add("29538");
                    break;
                case "lightningstorm":
                    OpponentCards.Add("29549");
                    break;
                case "lightschampion":
                    OpponentCards.Add("31060");
                    break;
                case "lightsjustice":
                    OpponentCards.Add("29243");
                    break;
                case "lightspawn":
                    OpponentCards.Add("29583");
                    break;
                case "lightwarden":
                    OpponentCards.Add("29423");
                    break;
                case "lightwell":
                    OpponentCards.Add("29585");
                    break;
                case "lilexorcist":
                    OpponentCards.Add("30638");
                    break;
                case "livingroots":
                    OpponentCards.Add("30955");
                    break;
                case "loatheb":
                    OpponentCards.Add("30383");
                    break;
                case "lockandload":
                    OpponentCards.Add("30995");
                    break;
                case "loothoarder":
                    OpponentCards.Add("29475");
                    break;
                case "lordjaraxxus":
                    OpponentCards.Add("29577");
                    break;
                case "lordofthearena":
                    OpponentCards.Add("29275");
                    break;
                case "lorewalkercho":
                    OpponentCards.Add("29477");
                    break;
                case "losttallstrider":
                    OpponentCards.Add("30608");
                    break;
                case "lowlysquire":
                    OpponentCards.Add("31028");
                    break;
                case "madbomber":
                    OpponentCards.Add("29467");
                    break;
                case "madscientist":
                    OpponentCards.Add("30349");
                    break;
                case "madderbomber":
                    OpponentCards.Add("30630");
                    break;
                case "maexxna":
                    OpponentCards.Add("30357");
                    break;
                case "magmarager":
                    OpponentCards.Add("29260");
                    break;
                case "magnatauralpha":
                    OpponentCards.Add("31005");
                    break;
                case "magnibronzebeard":
                    OpponentCards.Add("29822");
                    break;
                case "maidenofthelake":
                    OpponentCards.Add("31034");
                    break;
                case "majordomoexecutus":
                    OpponentCards.Add("30890");
                    break;
                case "malganis":
                    OpponentCards.Add("30529");
                    break;
                case "malorne":
                    OpponentCards.Add("30555");
                    break;
                case "malygos":
                    OpponentCards.Add("29656");
                    break;
                case "manaaddict":
                    OpponentCards.Add("29457");
                    break;
                case "manatidetotem":
                    OpponentCards.Add("29668");
                    break;
                case "manawraith":
                    OpponentCards.Add("29701");
                    break;
                case "manawyrm":
                    OpponentCards.Add("29730");
                    break;
                case "markofnature":
                    OpponentCards.Add("29505");
                    break;
                case "markofthewild":
                    OpponentCards.Add("29186");
                    break;
                case "massdispel":
                    OpponentCards.Add("29713");
                    break;
                case "masterjouster":
                    OpponentCards.Add("31066");
                    break;
                case "masterofceremonies":
                    OpponentCards.Add("31073");
                    break;
                case "masterofdisguise":
                    OpponentCards.Add("29732");
                    break;
                case "masterswordsmith":
                    OpponentCards.Add("29757");
                    break;
                case "mechanicalyeti":
                    OpponentCards.Add("30616");
                    break;
                case "mech-bear-cat":
                    OpponentCards.Add("30554");
                    break;
                case "mechwarper":
                    OpponentCards.Add("30510");
                    break;
                case "medivh":
                    OpponentCards.Add("29824");
                    break;
                case "mekgineerthermaplugg":
                    OpponentCards.Add("30664");
                    break;
                case "metaltoothleaper":
                    OpponentCards.Add("30575");
                    break;
                case "micromachine":
                    OpponentCards.Add("30647");
                    break;
                case "millhousemanastorm":
                    OpponentCards.Add("29751");
                    break;
                case "mimironshead":
                    OpponentCards.Add("30658");
                    break;
                case "mindblast":
                    OpponentCards.Add("29314");
                    break;
                case "mindcontrol":
                    OpponentCards.Add("29176");
                    break;
                case "mindcontroltech":
                    OpponentCards.Add("29469");
                    break;
                case "mindvision":
                    OpponentCards.Add("29179");
                    break;
                case "mindgames":
                    OpponentCards.Add("29586");
                    break;
                case "mini-mage":
                    OpponentCards.Add("30655");
                    break;
                case "mirrorentity":
                    OpponentCards.Add("29558");
                    break;
                case "mirrorimage":
                    OpponentCards.Add("29201");
                    break;
                case "misdirection":
                    OpponentCards.Add("29634");
                    break;
                case "mistressofpain":
                    OpponentCards.Add("30525");
                    break;
                case "mogortheogre":
                    OpponentCards.Add("30660");
                    break;
                case "mogorschampion":
                    OpponentCards.Add("31038");
                    break;
                case "mogushanwarden":
                    OpponentCards.Add("29611");
                    break;
                case "moltengiant":
                    OpponentCards.Add("29705");
                    break;
                case "moonfire":
                    OpponentCards.Add("29185");
                    break;
                case "mortalcoil":
                    OpponentCards.Add("29333");
                    break;
                case "mortalstrike":
                    OpponentCards.Add("29617");
                    break;
                case "mountaingiant":
                    OpponentCards.Add("29481");
                    break;
                case "mountedraptor":
                    OpponentCards.Add("30195");
                    break;
                case "muklaschampion":
                    OpponentCards.Add("31041");
                    break;
                case "mulch":
                    OpponentCards.Add("30972");
                    break;
                case "multi-shot":
                    OpponentCards.Add("29311");
                    break;
                case "murlocknight":
                    OpponentCards.Add("31020");
                    break;
                case "murlocraider":
                    OpponentCards.Add("29276");
                    break;
                case "murloctidecaller":
                    OpponentCards.Add("29629");
                    break;
                case "murloctidehunter":
                    OpponentCards.Add("29342");
                    break;
                case "murloctinyfin":
                    OpponentCards.Add("30091");
                    break;
                case "murlocwarleader":
                    OpponentCards.Add("29627");
                    break;
                case "museumcurator":
                    OpponentCards.Add("30161");
                    break;
                case "musterforbattle":
                    OpponentCards.Add("30594");
                    break;
                case "mysteriouschallenger":
                    OpponentCards.Add("31024");
                    break;
                case "nagaseawitch":
                    OpponentCards.Add("30191");
                    break;
                case "natpagle":
                    OpponentCards.Add("29649");
                    break;
                case "naturalize":
                    OpponentCards.Add("29518");
                    break;
                case "nefarian":
                    OpponentCards.Add("30897");
                    break;
                case "neptulon":
                    OpponentCards.Add("30566");
                    break;
                case "nerubarweblord":
                    OpponentCards.Add("30366");
                    break;
                case "nerubianegg":
                    OpponentCards.Add("30353");
                    break;
                case "nexus-championsaraad":
                    OpponentCards.Add("31085");
                    break;
                case "nightblade":
                    OpponentCards.Add("29352");
                    break;
                case "noblesacrifice":
                    OpponentCards.Add("29490");
                    break;
                case "northseakraken":
                    OpponentCards.Add("31057");
                    break;
                case "northshirecleric":
                    OpponentCards.Add("29296");
                    break;
                case "nourish":
                    OpponentCards.Add("29521");
                    break;
                case "noviceengineer":
                    OpponentCards.Add("29316");
                    break;
                case "nozdormu":
                    OpponentCards.Add("29652");
                    break;
                case "oasissnapjaw":
                    OpponentCards.Add("29261");
                    break;
                case "obsidiandestroyer":
                    OpponentCards.Add("30166");
                    break;
                case "ogrebrute":
                    OpponentCards.Add("30599");
                    break;
                case "ogremagi":
                    OpponentCards.Add("29286");
                    break;
                case "ogreninja":
                    OpponentCards.Add("30628");
                    break;
                case "ogrewarmaul":
                    OpponentCards.Add("30583");
                    break;
                case "oldmurk-eye":
                    OpponentCards.Add("30227");
                    break;
                case "one-eyedcheat":
                    OpponentCards.Add("30537");
                    break;
                case "onyxia":
                    OpponentCards.Add("29655");
                    break;
                case "orgrimmaraspirant":
                    OpponentCards.Add("31003");
                    break;
                case "patientassassin":
                    OpponentCards.Add("29631");
                    break;
                case "perditionsblade":
                    OpponentCards.Add("29495");
                    break;
                case "pilotedshredder":
                    OpponentCards.Add("30637");
                    break;
                case "pilotedskygolem":
                    OpponentCards.Add("30650");
                    break;
                case "pint-sizedsummoner":
                    OpponentCards.Add("29464");
                    break;
                case "pitfighter":
                    OpponentCards.Add("31055");
                    break;
                case "pitlord":
                    OpponentCards.Add("29569");
                    break;
                case "pitsnake":
                    OpponentCards.Add("30169");
                    break;
                case "poisonseeds":
                    OpponentCards.Add("30368");
                    break;
                case "poisonedblade":
                    OpponentCards.Add("30949");
                    break;
                case "polymorph":
                    OpponentCards.Add("29195");
                    break;
                case "polymorph:boar":
                    OpponentCards.Add("30907");
                    break;
                case "powerofthewild":
                    OpponentCards.Add("29513");
                    break;
                case "poweroverwhelming":
                    OpponentCards.Add("29571");
                    break;
                case "powerword:glory":
                    OpponentCards.Add("30918");
                    break;
                case "powerword:shield":
                    OpponentCards.Add("29180");
                    break;
                case "powermace":
                    OpponentCards.Add("30556");
                    break;
                case "powershot":
                    OpponentCards.Add("30989");
                    break;
                case "preparation":
                    OpponentCards.Add("29500");
                    break;
                case "priestessofelune":
                    OpponentCards.Add("29671");
                    break;
                case "prophetvelen":
                    OpponentCards.Add("29589");
                    break;
                case "puddlestomper":
                    OpponentCards.Add("30598");
                    break;
                case "pyroblast":
                    OpponentCards.Add("29553");
                    break;
                case "quartermaster":
                    OpponentCards.Add("30592");
                    break;
                case "questingadventurer":
                    OpponentCards.Add("29449");
                    break;
                case "quickshot":
                    OpponentCards.Add("30873");
                    break;
                case "ragingworgen":
                    OpponentCards.Add("29625");
                    break;
                case "ragnarosthefirelord":
                    OpponentCards.Add("29561");
                    break;
                case "raidleader":
                    OpponentCards.Add("29264");
                    break;
                case "ramwrangler":
                    OpponentCards.Add("30914");
                    break;
                case "rampage":
                    OpponentCards.Add("29397");
                    break;
                case "ravenidol":
                    OpponentCards.Add("30220");
                    break;
                case "ravenholdtassassin":
                    OpponentCards.Add("29403");
                    break;
                case "razorfenhunter":
                    OpponentCards.Add("29285");
                    break;
                case "recklessrocketeer":
                    OpponentCards.Add("29289");
                    break;
                case "recombobulator":
                    OpponentCards.Add("30654");
                    break;
                case "recruiter":
                    OpponentCards.Add("31067");
                    break;
                case "recycle":
                    OpponentCards.Add("30549");
                    break;
                case "redemption":
                    OpponentCards.Add("29497");
                    break;
                case "refreshmentvendor":
                    OpponentCards.Add("31065");
                    break;
                case "reincarnate":
                    OpponentCards.Add("30377");
                    break;
                case "reliquaryseeker":
                    OpponentCards.Add("30223");
                    break;
                case "rendblackhand":
                    OpponentCards.Add("30896");
                    break;
                case "renojackson":
                    OpponentCards.Add("30170");
                    break;
                case "repentance":
                    OpponentCards.Add("29600");
                    break;
                case "resurrect":
                    OpponentCards.Add("30878");
                    break;
                case "revenge":
                    OpponentCards.Add("30876");
                    break;
                case "rhonin":
                    OpponentCards.Add("30913");
                    break;
                case "rivercrocolisk":
                    OpponentCards.Add("29262");
                    break;
                case "rockbiterweapon":
                    OpponentCards.Add("29211");
                    break;
                case "rumblingelemental":
                    OpponentCards.Add("30172");
                    break;
                case "sabotage":
                    OpponentCards.Add("30574");
                    break;
                case "saboteur":
                    OpponentCards.Add("31035");
                    break;
                case "sacredtrial":
                    OpponentCards.Add("30188");
                    break;
                case "sacrificialpact":
                    OpponentCards.Add("29373");
                    break;
                case "saltydog":
                    OpponentCards.Add("30607");
                    break;
                case "sap":
                    OpponentCards.Add("29349");
                    break;
                case "savagecombatant":
                    OpponentCards.Add("30960");
                    break;
                case "savageroar":
                    OpponentCards.Add("29188");
                    break;
                case "savagery":
                    OpponentCards.Add("29670");
                    break;
                case "savannahhighmane":
                    OpponentCards.Add("29635");
                    break;
                case "scarletcrusader":
                    OpponentCards.Add("29440");
                    break;
                case "scarletpurifier":
                    OpponentCards.Add("30643");
                    break;
                case "scavenginghyena":
                    OpponentCards.Add("29632");
                    break;
                case "screwjankclunker":
                    OpponentCards.Add("30584");
                    break;
                case "seagiant":
                    OpponentCards.Add("29674");
                    break;
                case "seareaver":
                    OpponentCards.Add("31088");
                    break;
                case "sealofchampions":
                    OpponentCards.Add("31016");
                    break;
                case "sealoflight":
                    OpponentCards.Add("30588");
                    break;
                case "secretkeeper":
                    OpponentCards.Add("29465");
                    break;
                case "senjinshieldmasta":
                    OpponentCards.Add("29280");
                    break;
                case "sensedemons":
                    OpponentCards.Add("29573");
                    break;
                case "shadeofnaxxramas":
                    OpponentCards.Add("30350");
                    break;
                case "shado-panrider":
                    OpponentCards.Add("30940");
                    break;
                case "shadowbolt":
                    OpponentCards.Add("29220");
                    break;
                case "shadowmadness":
                    OpponentCards.Add("29581");
                    break;
                case "shadowword:death":
                    OpponentCards.Add("29354");
                    break;
                case "shadowword:pain":
                    OpponentCards.Add("29295");
                    break;
                case "shadowbomber":
                    OpponentCards.Add("30513");
                    break;
                case "shadowboxer":
                    OpponentCards.Add("30609");
                    break;
                case "shadowfiend":
                    OpponentCards.Add("30920");
                    break;
                case "shadowflame":
                    OpponentCards.Add("29563");
                    break;
                case "shadowform":
                    OpponentCards.Add("29710");
                    break;
                case "shadowstep":
                    OpponentCards.Add("29499");
                    break;
                case "shadydealer":
                    OpponentCards.Add("30946");
                    break;
                case "shatteredsuncleric":
                    OpponentCards.Add("29317");
                    break;
                case "shieldblock":
                    OpponentCards.Add("29353");
                    break;
                case "shieldslam":
                    OpponentCards.Add("29621");
                    break;
                case "shieldbearer":
                    OpponentCards.Add("29615");
                    break;
                case "shieldedminibot":
                    OpponentCards.Add("30590");
                    break;
                case "shieldmaiden":
                    OpponentCards.Add("30582");
                    break;
                case "shipscannon":
                    OpponentCards.Add("30612");
                    break;
                case "shiv":
                    OpponentCards.Add("29332");
                    break;
                case "shrinkmeister":
                    OpponentCards.Add("30516");
                    break;
                case "si:7agent":
                    OpponentCards.Add("29496");
                    break;
                case "sideshowspelleater":
                    OpponentCards.Add("31051");
                    break;
                case "siegeengine":
                    OpponentCards.Add("30625");
                    break;
                case "silence":
                    OpponentCards.Add("29580");
                    break;
                case "silentknight":
                    OpponentCards.Add("31047");
                    break;
                case "siltfinspiritwalker":
                    OpponentCards.Add("30561");
                    break;
                case "silverhandknight":
                    OpponentCards.Add("29401");
                    break;
                case "silverhandregent":
                    OpponentCards.Add("31054");
                    break;
                case "silverbackpatriarch":
                    OpponentCards.Add("29268");
                    break;
                case "silvermoonguardian":
                    OpponentCards.Add("29442");
                    break;
                case "sinisterstrike":
                    OpponentCards.Add("29230");
                    break;
                case "siphonsoul":
                    OpponentCards.Add("29566");
                    break;
                case "sirfinleymrrgglton":
                    OpponentCards.Add("30202");
                    break;
                case "skycapnkragg":
                    OpponentCards.Add("31010");
                    break;
                case "slam":
                    OpponentCards.Add("29608");
                    break;
                case "sludgebelcher":
                    OpponentCards.Add("30359");
                    break;
                case "snaketrap":
                    OpponentCards.Add("29646");
                    break;
                case "sneedsoldshredder":
                    OpponentCards.Add("30662");
                    break;
                case "snipe":
                    OpponentCards.Add("29691");
                    break;
                case "snowchugger":
                    OpponentCards.Add("30506");
                    break;
                case "solemnvigil":
                    OpponentCards.Add("30850");
                    break;
                case "sootspewer":
                    OpponentCards.Add("30671");
                    break;
                case "sorcerersapprentice":
                    OpponentCards.Add("29690");
                    break;
                case "souloftheforest":
                    OpponentCards.Add("29510");
                    break;
                case "soulfire":
                    OpponentCards.Add("29335");
                    break;
                case "southseacaptain":
                    OpponentCards.Add("29749");
                    break;
                case "southseadeckhand":
                    OpponentCards.Add("29400");
                    break;
                case "sparringpartner":
                    OpponentCards.Add("31008");
                    break;
                case "spawnofshadows":
                    OpponentCards.Add("30917");
                    break;
                case "spectralknight":
                    OpponentCards.Add("30355");
                    break;
                case "spellbender":
                    OpponentCards.Add("29767");
                    break;
                case "spellbreaker":
                    OpponentCards.Add("29454");
                    break;
                case "spellslinger":
                    OpponentCards.Add("30911");
                    break;
                case "spidertank":
                    OpponentCards.Add("30569");
                    break;
                case "spitefulsmith":
                    OpponentCards.Add("29410");
                    break;
                case "sprint":
                    OpponentCards.Add("29232");
                    break;
                case "stablemaster":
                    OpponentCards.Add("30990");
                    break;
                case "stalagg":
                    OpponentCards.Add("30362");
                    break;
                case "stampedingkodo":
                    OpponentCards.Add("29763");
                    break;
                case "starfall":
                    OpponentCards.Add("29723");
                    break;
                case "starfire":
                    OpponentCards.Add("29326");
                    break;
                case "starvingbuzzard":
                    OpponentCards.Add("29299");
                    break;
                case "steamwheedlesniper":
                    OpponentCards.Add("30627");
                    break;
                case "stoneskingargoyle":
                    OpponentCards.Add("30379");
                    break;
                case "stonesplintertrogg":
                    OpponentCards.Add("30601");
                    break;
                case "stonetuskboar":
                    OpponentCards.Add("29277");
                    break;
                case "stormforgedaxe":
                    OpponentCards.Add("29542");
                    break;
                case "stormpikecommando":
                    OpponentCards.Add("29273");
                    break;
                case "stormwindchampion":
                    OpponentCards.Add("29290");
                    break;
                case "stormwindknight":
                    OpponentCards.Add("29269");
                    break;
                case "stranglethorntiger":
                    OpponentCards.Add("29443");
                    break;
                case "succubus":
                    OpponentCards.Add("29334");
                    break;
                case "summoningportal":
                    OpponentCards.Add("29570");
                    break;
                case "summoningstone":
                    OpponentCards.Add("30205");
                    break;
                case "sunfuryprotector":
                    OpponentCards.Add("29460");
                    break;
                case "sunwalker":
                    OpponentCards.Add("29445");
                    break;
                case "swipe":
                    OpponentCards.Add("29190");
                    break;
                case "swordofjustice":
                    OpponentCards.Add("29598");
                    break;
                case "sylvanaswindrunner":
                    OpponentCards.Add("29438");
                    break;
                case "targetdummy":
                    OpponentCards.Add("30634");
                    break;
                case "taurenwarrior":
                    OpponentCards.Add("29607");
                    break;
                case "templeenforcer":
                    OpponentCards.Add("29707");
                    break;
                case "thebeast":
                    OpponentCards.Add("29669");
                    break;
                case "theblackknight":
                    OpponentCards.Add("29425");
                    break;
                case "themistcaller":
                    OpponentCards.Add("30987");
                    break;
                case "theskeletonknight":
                    OpponentCards.Add("31086");
                    break;
                case "thoughtsteal":
                    OpponentCards.Add("29584");
                    break;
                case "thrallmarfarseer":
                    OpponentCards.Add("29441");
                    break;
                case "thunderbluffvaliant":
                    OpponentCards.Add("30980");
                    break;
                case "timberwolf":
                    OpponentCards.Add("29307");
                    break;
                case "tinkerssharpswordoil":
                    OpponentCards.Add("30531");
                    break;
                case "tinkertowntechnician":
                    OpponentCards.Add("30645");
                    break;
                case "tinkmasteroverspark":
                    OpponentCards.Add("29468");
                    break;
                case "tinyknightofevil":
                    OpponentCards.Add("30930");
                    break;
                case "tirionfordring":
                    OpponentCards.Add("29604");
                    break;
                case "tombpillager":
                    OpponentCards.Add("30171");
                    break;
                case "tombspider":
                    OpponentCards.Add("30194");
                    break;
                case "toshley":
                    OpponentCards.Add("30663");
                    break;
                case "totemgolem":
                    OpponentCards.Add("30985");
                    break;
                case "totemicmight":
                    OpponentCards.Add("29327");
                    break;
                case "tournamentattendee":
                    OpponentCards.Add("31050");
                    break;
                case "tournamentmedic":
                    OpponentCards.Add("31043");
                    break;
                case "tracking":
                    OpponentCards.Add("29312");
                    break;
                case "tradeprincegallywix":
                    OpponentCards.Add("30541");
                    break;
                case "treeoflife":
                    OpponentCards.Add("30553");
                    break;
                case "troggzortheearthinator":
                    OpponentCards.Add("30666");
                    break;
                case "truesilverchampion":
                    OpponentCards.Add("29248");
                    break;
                case "tundrarhino":
                    OpponentCards.Add("29309");
                    break;
                case "tunneltrogg":
                    OpponentCards.Add("30176");
                    break;
                case "tuskarrjouster":
                    OpponentCards.Add("31058");
                    break;
                case "tuskarrtotemic":
                    OpponentCards.Add("30976");
                    break;
                case "twilightdrake":
                    OpponentCards.Add("29447");
                    break;
                case "twilightguardian":
                    OpponentCards.Add("30925");
                    break;
                case "twilightwhelp":
                    OpponentCards.Add("30855");
                    break;
                case "twistingnether":
                    OpponentCards.Add("29568");
                    break;
                case "unboundelemental":
                    OpponentCards.Add("29547");
                    break;
                case "undercityvaliant":
                    OpponentCards.Add("30944");
                    break;
                case "undertaker":
                    OpponentCards.Add("30380");
                    break;
                case "unearthedraptor":
                    OpponentCards.Add("30178");
                    break;
                case "unleashthehounds":
                    OpponentCards.Add("29640");
                    break;
                case "unstableghoul":
                    OpponentCards.Add("30376");
                    break;
                case "unstableportal":
                    OpponentCards.Add("30507");
                    break;
                case "upgrade!":
                    OpponentCards.Add("29618");
                    break;
                case "upgradedrepairbot":
                    OpponentCards.Add("30622");
                    break;
                case "vanish":
                    OpponentCards.Add("29374");
                    break;
                case "vaporize":
                    OpponentCards.Add("29678");
                    break;
                case "varianwrynn":
                    OpponentCards.Add("31013");
                    break;
                case "velenschosen":
                    OpponentCards.Add("30514");
                    break;
                case "ventureco.mercenary":
                    OpponentCards.Add("29412");
                    break;
                case "violetteacher":
                    OpponentCards.Add("29747");
                    break;
                case "vitalitytotem":
                    OpponentCards.Add("30560");
                    break;
                case "voidcrusher":
                    OpponentCards.Add("30933");
                    break;
                case "voidterror":
                    OpponentCards.Add("29564");
                    break;
                case "voidcaller":
                    OpponentCards.Add("30373");
                    break;
                case "voidwalker":
                    OpponentCards.Add("29226");
                    break;
                case "volcanicdrake":
                    OpponentCards.Add("30888");
                    break;
                case "volcaniclumberer":
                    OpponentCards.Add("30863");
                    break;
                case "voljin":
                    OpponentCards.Add("30520");
                    break;
                case "voodoodoctor":
                    OpponentCards.Add("29315");
                    break;
                case "wailingsoul":
                    OpponentCards.Add("30365");
                    break;
                case "wargolem":
                    OpponentCards.Add("29282");
                    break;
                case "warbot":
                    OpponentCards.Add("30580");
                    break;
                case "warhorsetrainer":
                    OpponentCards.Add("31018");
                    break;
                case "warsongcommander":
                    OpponentCards.Add("29322");
                    break;
                case "waterelemental":
                    OpponentCards.Add("29204");
                    break;
                case "webspinner":
                    OpponentCards.Add("30358");
                    break;
                case "weespellstopper":
                    OpponentCards.Add("30670");
                    break;
                case "whirlingzap-o-matic":
                    OpponentCards.Add("30558");
                    break;
                case "whirlwind":
                    OpponentCards.Add("29341");
                    break;
                case "wildgrowth":
                    OpponentCards.Add("29191");
                    break;
                case "wildpyromancer":
                    OpponentCards.Add("29739");
                    break;
                case "wildwalker":
                    OpponentCards.Add("30962");
                    break;
                case "wilfredfizzlebang":
                    OpponentCards.Add("30938");
                    break;
                case "windfury":
                    OpponentCards.Add("29207");
                    break;
                case "windfuryharpy":
                    OpponentCards.Add("29446");
                    break;
                case "windspeaker":
                    OpponentCards.Add("29351");
                    break;
                case "wisp":
                    OpponentCards.Add("29413");
                    break;
                case "wobblingrunts":
                    OpponentCards.Add("30206");
                    break;
                case "wolfrider":
                    OpponentCards.Add("29266");
                    break;
                case "worgeninfiltrator":
                    OpponentCards.Add("29433");
                    break;
                case "wrath":
                    OpponentCards.Add("29502");
                    break;
                case "wrathguard":
                    OpponentCards.Add("30937");
                    break;
                case "wyrmrestagent":
                    OpponentCards.Add("31071");
                    break;
                case "youngdragonhawk":
                    OpponentCards.Add("29404");
                    break;
                case "youngpriestess":
                    OpponentCards.Add("29426");
                    break;
                case "youthfulbrewmaster":
                    OpponentCards.Add("29455");
                    break;
                case "ysera":
                    OpponentCards.Add("29662");
                    break;
                case "zombiechow":
                    OpponentCards.Add("30345");
                    break;
                default:
                    break;
            }
        }
        
        public static void Load() 
		{
			_opponent = null;

            // A border to put around the text block
           Border blockBorder = new Border();
			blockBorder.BorderBrush = Brushes.Black;
			blockBorder.BorderThickness = new Thickness(1.0);
			blockBorder.Padding = new Thickness(0.0);

			// A text block using the HS font
			_info = new HearthstoneTextBlock();
			_info.Text = "";
			_info.FontSize = 20;
            _info.PreviewKeyDown += new KeyEventHandler(button1_KeyDown);

            // Add the text block as a child of the border element
            //blockBorder.Child = _info;

			// Create an image at the corner of the text bloxk
			//Image image = new Image();
			// Create the image source
			//BitmapImage bi = new BitmapImage(new Uri("pack://siteoforigin:,,,/Plugins/card.png"));
			// Set the image source
			//image.Source = bi;

			// Get the HDT Overlay canvas object
			var canvas = Hearthstone_Deck_Tracker.API.Core.OverlayCanvas;
			// Get canvas centre
			var fromTop = canvas.Height / 2;
			var fromLeft = canvas.Width / 2;
			// Give the text block its position within the canvas, roughly in the center
			Canvas.SetTop(blockBorder, fromTop);
			Canvas.SetLeft(blockBorder, fromLeft);
			// Give the text block its position within the canvas
			//Canvas.SetTop(image, fromTop - 12);
			//Canvas.SetLeft(image, fromLeft - 12);
			// Add the text block and image to the canvas
			canvas.Children.Add(blockBorder);
			//canvas.Children.Add(image);

			// Register methods to be called when GameEvents occur
			GameEvents.OnGameStart.Add(NewGame);
            GameEvents.OnOpponentPlay.Add(HandInfo);
        }

        // By default, KeyDown does not fire for the ARROW keys
        private static void button1_KeyDown(object sender, KeyEventArgs e)
            {
            MessageBox.Show("Ctrl+Alt+O: magic!");
            if (e.Key == Key.Return)
                {
                    System.Diagnostics.Process.Start(URLToOpen);
                }
                e.Handled = true;
            }

        // Set the player controller id, used to tell who controls a particular
        // entity (card, health etc.)
        private static void NewGame()
		{
            OpponentCards = new ArrayList();
			_opponent = null;
            _info.Text = "";
            if (PlayerEntity != null)
				_opponent = PlayerEntity.GetTag(GAME_TAG.CONTROLLER);		
		}

		// Find all cards in the players hand and write to the text block
		public static void HandInfo(Card c)
		{
			if (_opponent == null)
				NewGame();

            //Disregard The Coin and only add cards once
            if (!c.Name.Contains("The Coin") && !_info.Text.Contains(c.Name.ToLower()) && !c.IsCreated)
            {
                //Only keep a -> z
                c.Name = RemoveSpecialCharacters(c.Name.ToLower());
                _info.Text += c.Name + "\n";
                SetUpCardDatabase(c.Name);

                URLToOpen = "http://www.hearthpwn.com/decks?filter-contains-card=" + OpponentCards[0];

                foreach (String e in OpponentCards)
                {
                    if (e.Equals(OpponentCards[0]))
                    {

                    }
                    else { URLToOpen += "&filter-contains-card=" + e; }
                }
                URLToOpen += "&filter-deck-tag=1";
                //System.Diagnostics.Process.Start(URLToOpen);
            }
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

    }
}