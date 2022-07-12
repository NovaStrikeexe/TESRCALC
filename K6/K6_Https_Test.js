import http from 'k6/http';
const url = 'https://localhost:5001';

export let options = {
    stages: [
        { duration: '10s', target: 5 },
    ],
};
export default function () {
    http.put(url);

}