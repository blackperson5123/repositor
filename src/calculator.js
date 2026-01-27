// Калькулятор - основная реализация

class Calculator {
    constructor() {
        this.result = 0;
    }

    // Сложение
    add(a, b) {
        this.result = a + b;
        return this.result;
    }

    // Вспомогательная функция проверки
    isValidNumber(num) {
        return typeof num === 'number' && !isNaN(num);
    }

    // Получить результат
    getResult() {
        return this.result;
    }

    // Сброс результата
    reset() {
        this.result = 0;
    }
}

module.exports = Calculator;
