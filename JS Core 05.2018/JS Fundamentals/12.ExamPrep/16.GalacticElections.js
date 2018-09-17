function solve(arr) {
    let systems = {};

    for (let line of arr) {
        let [system, candidate, votes] = [line.system, line.candidate, line.votes];
        
        if (!systems.hasOwnProperty(system)) {
            systems[system] = {};
            systems[system][candidate] = votes;
        } else if (!systems[system].hasOwnProperty(candidate)){
            systems[system][candidate] = votes;
        } else {
            systems[system][candidate] += votes;
        }
    }

    let winners = {};

    for (let system in systems) {
        let sortedCandidates = Object.keys(systems[system]).sort((a , b) => {
            return systems[system][b] - systems[system][a];
        });
        let winner = sortedCandidates[0];
        let totalVotes = 0;

        for (let cand in systems[system]) {
            totalVotes += systems[system][cand];
        }

        winners[system] = {};
        winners[system][winner] = totalVotes;
    }

    let grandTotalVotes = 0;
    for (let sys in winners) {
        for (let winner in winners[sys]) {
            grandTotalVotes += winners[sys][winner];
        }
    }

    let finalVotes = {};

    for (let sys in winners) {
        for (const cand in winners[sys]) {
            if (!finalVotes.hasOwnProperty(cand)) {
                finalVotes[cand] = winners[sys][cand];
            } else {
                finalVotes[cand] += winners[sys][cand];
            }
        }
    }

    let sortedWinners = Object.keys(finalVotes).sort((a, b) => {
        return finalVotes[b] - finalVotes[a];
    });
    let finalWinner = sortedWinners[0];

    if (sortedWinners.length === 1) {
        console.log(`${finalWinner} wins with ${finalVotes[finalWinner]} votes`);
        console.log(`${finalWinner} wins unopposed!`);
    } else if (finalVotes[finalWinner] / grandTotalVotes < 0.5) {
        let runnerUp = sortedWinners[1];
        let winnerPercent = Math.floor(finalVotes[finalWinner] / grandTotalVotes * 100);
        let runnerPercent = Math.floor(finalVotes[runnerUp] / grandTotalVotes * 100);
        console.log(`Runoff between ${finalWinner} with ${winnerPercent}% and ${runnerUp} with ${runnerPercent}%`);
    } else {
        let runnerUp = sortedWinners[1];
        console.log(`${finalWinner} wins with ${finalVotes[finalWinner]} votes`);
        console.log(`Runner up: ${runnerUp}`);

        let runnerUpWins = {};
        for (let sys in winners) {
            for (let cand in winners[sys]) {
                if (cand === runnerUp) {
                    runnerUpWins[sys] = winners[sys][cand];
                }
            }
        }
        let sortedRunnerUpWins = Object.keys(runnerUpWins).sort((a, b) => {
            return runnerUpWins[b] - runnerUpWins[a];
        });

        for (let win of sortedRunnerUpWins) {
            console.log(`${win}: ${runnerUpWins[win]}`);
        }
    }
}

solve([ { system: 'Tau',     candidate: 'Flying Shrimp', votes: 150 },
    { system: 'Tau',     candidate: 'Space Cow',     votes: 100 },
    { system: 'Theta',   candidate: 'Space Cow',     votes: 10 },
    { system: 'Sigma',   candidate: 'Space Cow',     votes: 200 },
    { system: 'Sigma',   candidate: 'Flying Shrimp', votes: 75 },
    { system: 'Omicron', candidate: 'Flying Shrimp', votes: 50 },
    { system: 'Omicron', candidate: 'Octocat',       votes: 75 } ]);