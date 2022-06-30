import http from 'k6/http';
const url = 'https://localhost:5001';

export let options = {
    stages: [
        { duration: '1s', target: 1500 },
        
    ],
};
export default function () {
    http.put(url);
}