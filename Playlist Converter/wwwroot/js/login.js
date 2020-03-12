(function () {
    //
    var userCountry = "US";
    var localApi = new localProxyApi(serverBasePath);
    var spotifyWebApi = new SpotifyWebApi();






    //Following 3 funtcions taken from artist explorer main.js file

    function login() {
        return new Promise(function (resolve, reject) {
            OAuthManager.obtainToken({
                scopes: [
                    'playlist-read-private',
                    'playlist-modify-public',
                    'playlist-modify-private'
                ]
            }).then(function (token) {
                resolve(onTokenReceived(token));
            }).catch(function (error) {
                console.error(error);
            });
        });
    }
    function getDisplayName(str) {
        var maxDisplayLength = 11;
        if (str.length < maxDisplayLength) {
            return str;
        }

        var spaceIndex = str.indexOf(' ');
        if (spaceIndex != -1 && spaceIndex < maxDisplayLength) {
            return str.substr(0, spaceIndex);
        }
        return str.substr(0, maxDisplayLength);
    }

    function onTokenReceived(accessToken) {
        return new Promise(function (resolve, reject) {
            artistInfoModel.isLoggedIn(true);
            spotifyWebApi.setAccessToken(accessToken);
            localStorage.setItem('ae_token', accessToken);
            localStorage.setItem('ae_expires', (new Date()).getTime() + 3600 * 1000); // 1 hour
            spotifyWebApi.getMe().then(function (data) {
                artistInfoModel.userId(data.id);
                artistInfoModel.displayName(getDisplayName(data.display_name));
                artistInfoModel.userImage(data.images[0].url);
                localStorage.setItem('ae_userid', data.id);
                localStorage.setItem('ae_display_name', data.display_name);
                localStorage.setItem('ae_user_image', data.images[0].url);
                currentApi = spotifyWebApi;
                resolve(checkArtistExplorerPlaylistExists(artistInfoModel.userId(), 0, 50));
            });

        });
    }

    window.AE = {
        getSuitableImage: getSuitableImage,
        getRelated: getRelated,
        getArtistsForGenre: getArtistsForGenre,
        getInfoCancel: getInfoCancel,
        getInfo: getInfo,
        changeNumberOfArtists: changeNumberOfArtists,
        setRepeatArtists: setRepeatArtists,
        toTitleCase: toTitleCase,
        artistInfoModel: artistInfoModel,
        login: login,
        createPlaylistModal: createPlaylistModal,
        createPlaylist: createPlaylist,
        logout: logout
    };








})