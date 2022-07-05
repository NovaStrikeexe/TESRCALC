import http from 'k6/http';
const url = 'https://localhost:5001';

export let options = {
    stages: [
        { duration: '10s', target: 1000 },
        { duration: '10s', target: 1000 },
        { duration: '10s', target: 1000 },
        { duration: '10s', target: 1000 },
        { duration: '10s', target: 1000 },
        { duration: '10s', target: 1000 },
    ],
};
export default function () {
    http.put(url);
}