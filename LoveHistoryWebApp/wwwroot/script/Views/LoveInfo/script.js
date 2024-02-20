function updateStatus(loveStatusObj) {
    let url = "/loveinfo";

    fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(loveStatusObj)
    })
}

function switchCounter(isArguing) {
    if (isArgue === isArguing) {
        return;
    }

    if (isArgue && !isArguing) {
        // Send API update status from argue to dating
        totalArgueTime += Math.floor((new Date() - startArguingDate) / 1000);
        updateStatus({
            startDatingDate: startDatingDate,
            startArgueDate: startArguingDate,
            isArgue: false,
            totalArgueTime: totalArgueTime
        });
        document.getElementById('dating-avatar').classList.add('heartbeat-animation');
        document.getElementById('gian-nhau-avatar').classList.remove('heartbeat-animation');
    } else if (!isArgue && isArguing) {
        // Send API update status from dating to argue
        startArguingDate = new Date();
        updateStatus({
            startDatingDate: startDatingDate,
            startArgueDate: startArguingDate,
            isArgue: true,
            totalArgueTime: totalArgueTime
        });
        document.getElementById('dating-avatar').classList.remove('heartbeat-animation');
        document.getElementById('gian-nhau-avatar').classList.add('heartbeat-animation');
    }

    isArgue = !isArgue;
    document.getElementById('dating').classList.toggle('active');
    document.getElementById('arguing').classList.toggle('active');
}

function fromDurationInSecondsToString(durationInSeconds) {
    let seconds = Math.floor(durationInSeconds % 60);
    let minutes = Math.floor((durationInSeconds / 60) % 60);
    let hours = Math.floor((durationInSeconds / (60 * 60)) % 24);
    let days = Math.floor((durationInSeconds / (60 * 60 * 24)) % 30.44);
    let months = Math.floor((durationInSeconds / (60 * 60 * 24 * 30.44)) % 12);
    let years = Math.floor(durationInSeconds / (60 * 60 * 24 * 365.25));

    output = "";
    output += `${years} năm `;
    output += `${months} tháng `;
    output += `${days} ngày `;
    output += `${hours} giờ `;
    output += `${minutes} phút `;
    output += `${seconds} giây `;
    return output;
}

function initTime() {
    let currentDate = new Date();
    document.getElementById('arguingTime').innerText = fromDurationInSecondsToString(totalArgueTime);
    let durationInSeconds = Math.floor((currentDate - startDatingDate) / 1000 - totalArgueTime);
    document.getElementById('datingTime').innerText = fromDurationInSecondsToString(durationInSeconds);
}

function updateCounters() {
    let currentDate = new Date();

    if (isArgue) {
        let durationInSeconds = Math.floor((currentDate - startArguingDate) / 1000 + totalArgueTime);
        document.getElementById('arguingTime').innerText = fromDurationInSecondsToString(durationInSeconds);
    } else {
        let durationInSeconds = Math.floor((currentDate - startDatingDate) / 1000 - totalArgueTime);
        document.getElementById('datingTime').innerText = fromDurationInSecondsToString(durationInSeconds);
    }
}

function createHeart() {
    if (isArgue) {
        return;
    }
    let heart = document.createElement('i');
    heart.classList.add('fa', 'fa-heart', 'text-red-600', 'animate-bubble');
    heart.style.left = Math.random() * window.innerWidth + 'px';
    heart.style.position = 'absolute';
    heart.style.zIndex = '3';
    document.body.appendChild(heart);
    setTimeout(function () {
        document.body.removeChild(heart);
    }, 6000);
}