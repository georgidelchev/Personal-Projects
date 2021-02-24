function function1() {
    let arr = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]

    // arr.forEach(e => {
    //     console.log(`${i} - ${e}`);
    // });

    // console.log("---");

    // for (let i = 0; i < arr.length; i++) {
    //     console.log(`${i + 1} - ${arr[i]}`);
    // }

    // let i = 0;
    // for (; arr[i] !== undefined;) {
    //     console.log(arr[i]);
    //     i++;
    // }

    // let i = 0;

    // while (arr[i] !== undefined) {
    //     console.log(arr[i]);
    //     i++;
    // }

    // for (const key in arr) {
    //     console.log(arr[key]);
    // }

    // let result = arr.reduce(function(temp, day) {
    //     return temp + "\n" + day;
    // })

    // console.log(result);

    // console.log(arr.join("\n", arr));

    // let numArr = [2, 2, 2, 3, 5, 5, 5, 5, 5, 5, 5, 5];

    // let set = new Set(numArr);
    // set.forEach(element => {
    //     console.log(element);
    // });

    // let sum = 0;

    // let n = numArr.length;
    // for (let i = 0; i < n; i++) {
    //     sum += numArr[i];
    // }

    // numArr.forEach(element => {
    //     sum += element;
    // });

    // numArr.forEach(function(value) {
    //     sum += value
    // });

    // let sum = numArr.reduce(function(currSum, number) {
    //     return currSum + number;
    // })

    // numArr = numArr
    //     .filter(num => num > 2)

    // let numArr = [1, 2, 2, 2, 3, 5, 5, 5, 5, 5, 5, 5, 5];

    // let sum = numArr
    //     .reduce((currSum, num) => {
    //         let res = currSum;
    //         if (num > 2) {
    //             res += num;
    //         }

    //         return res;
    //     }, 0);

    // alert(sum);
    //TODAy
    // let celsius = [1, 37.5, 24.6, 12.5, 43.1, 23.2, 25.5, 27.7];
    // $('.input').html(celsius.join(' ; '))

    // let far = celsius.map(t => ((t * 1.8) + 32).toFixed(2));
    // $('.output').html(far.join(' ; '))

    // far.forEach(element => {
    //     console.log(element);
    // });

    // let nums = [10, 20, 30, 40, 50];
    // $('.input').html(nums.join(' ; '));

    // let numsSquares = nums.map(n => (Math.sqrt(n)).toFixed(2));
    // $('.output').html(numsSquares.join(' ; '));

    // numsSquares.filter(n => n > 10);
    // $('.output').html(numsSquares.join(' ; '));

    // let sum = nums.reduce((sum, n) => sum + n)
    // $('.output').html(sum);


    let student = [{
            firstName: 'Ivan',
            lastName: 'Ivanov',
            years: 19,
            course: 3,
            group: 1
        },

        {
            firstName: 'Dimitar',
            lastName: 'Dimitrov',
            years: 21,
            course: 2,
            group: 3
        },

        {
            firstName: 'Petar',
            lastName: 'Petrov',
            years: 22,
            course: 4,
            group: 1
        },
        {
            firstName: 'Iva',
            lastName: 'Dimitrova',
            years: 20,
            course: 2,
            group: 1
        },
        {
            firstName: 'Simona',
            lastName: 'Ivanova',
            years: 20,
            course: 1,
            group: 1
        },
        {
            firstName: 'Mitko',
            lastName: 'Ivanov',
            years: 24,
            course: 4,
            group: 2
        }
    ]

    // let filtered = student.filter(s => s.years >= 20)
    // filtered.map(s => $('.output').append(s.firstName + " " + s.lastName + " " + s.years + '<br/>'))

    let arr1 = Object.values(student);
    let sum = (sum, yrs) => ({ years: sum.years + yrs.years });
    let avg = arr1.reduce((sum)).years / arr1.length;

    console.log(avg);
}