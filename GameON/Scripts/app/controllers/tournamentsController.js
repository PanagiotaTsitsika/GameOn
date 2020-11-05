
let TournamentsController = function (participationService) {
    let button;
    let init = function (container) {
        $(container).on("click", ".js-toggle-participation", toggleParticipation)
    
    };

    let toggleParticipation = function (e) {
        button = $(e.target);
        let tournamentId = button.attr("data-tournament-id");
        if (button.hasClass("btn-default"))
            participationService.createAttendance(tournamentId, done, fail);
        else
            participationService.deleteAttendance(tournamentId, done, fail);
    };



    let done = function () {
        let text = button.text() === "Participating" ? "Participating?" : "Participating";
        button.toggleClass("btn-info").toggleClass("btn-default")
    };

    let fail = function () {
        alert("something failed");
    };

    return {
        init: init
    }

}(ParticipationService);