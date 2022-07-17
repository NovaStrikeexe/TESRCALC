import http from 'k6/http';
const url = 'https://localhost:5011/api/Calculator';

export let options = {
    stages: [
        { duration: '10s', target: 5 },
    ],
};
export default function () {
    http.put(url);

}