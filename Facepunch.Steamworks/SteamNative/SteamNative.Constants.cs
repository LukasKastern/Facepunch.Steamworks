using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	public static class CallbackIdentifiers
	{
		public const int SteamUser = 100;
		public const int SteamGameServer = 200;
		public const int SteamFriends = 300;
		public const int SteamBilling = 400;
		public const int SteamMatchmaking = 500;
		public const int SteamContentServer = 600;
		public const int SteamUtils = 700;
		public const int ClientFriends = 800;
		public const int ClientUser = 900;
		public const int SteamApps = 1000;
		public const int SteamUserStats = 1100;
		public const int SteamNetworking = 1200;
		public const int ClientRemoteStorage = 1300;
		public const int ClientDepotBuilder = 1400;
		public const int SteamGameServerItems = 1500;
		public const int ClientUtils = 1600;
		public const int SteamGameCoordinator = 1700;
		public const int SteamGameServerStats = 1800;
		public const int Steam2Async = 1900;
		public const int SteamGameStats = 2000;
		public const int ClientHTTP = 2100;
		public const int ClientScreenshots = 2200;
		public const int SteamScreenshots = 2300;
		public const int ClientAudio = 2400;
		public const int ClientUnifiedMessages = 2500;
		public const int SteamStreamLauncher = 2600;
		public const int ClientController = 2700;
		public const int SteamController = 2800;
		public const int ClientParentalSettings = 2900;
		public const int ClientDeviceAuth = 3000;
		public const int ClientNetworkDeviceManager = 3100;
		public const int ClientMusic = 3200;
		public const int ClientRemoteClientManager = 3300;
		public const int ClientUGC = 3400;
		public const int SteamStreamClient = 3500;
		public const int ClientShortcuts = 3700;
		public const int ClientRemoteControlManager = 3800;
		public const int SteamAppList = 3900;
		public const int SteamMusic = 4000;
		public const int SteamMusicRemote = 4100;
		public const int ClientVR = 4200;
		public const int ClientGameNotification = 4300;
		public const int SteamGameNotification = 4400;
		public const int SteamHTMLSurface = 4500;
		public const int ClientVideo = 4600;
		public const int ClientInventory = 4700;
		public const int ClientBluetoothManager = 4800;
	}
	public static class Defines
	{
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001";
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008";
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";
		public const string STEAMCONTROLLER_INTERFACE_VERSION = "SteamController004";
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends015";
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer012";
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_003";
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION002";
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V001";
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking005";
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION014";
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003";
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION009";
		public const string STEAMUNIFIEDMESSAGES_INTERFACE_VERSION = "STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001";
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser019";
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION011";
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils008";
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V001";
	}
}
