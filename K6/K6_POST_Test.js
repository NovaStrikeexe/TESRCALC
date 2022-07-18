import http from 'k6/http';

export const options = {
    vus: 1,
    duration: '5s'

}
export default function () {
    const url = 'https://localhost:5011/api/Calculator';
    const payload = JSON.stringify({
        "numberOne": 450,
        "numberTwo": 1,
        "typeOperation": "+"
    });

    const params = {
        headers: {
            'Content-Type': 'application/json',
        },
    };

    http.post(url, payload, params);
}