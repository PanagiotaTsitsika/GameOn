let ParticipationService = function () {

    let createAttendance = function (tournamentId, done, fail) {
        $.post("/api/participations", { tournamentId: tournamentId })
            .done(done)
            .fail(fail);
    };

    let deleteAttendance = function (tournamentId, done, fail) {
        $.ajax({
            url: "/api/participations/" + tournamentId,
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };

    return {
        createAttendance: createAttendance,
        deleteAttendance: deleteAttendance

    }


}();
