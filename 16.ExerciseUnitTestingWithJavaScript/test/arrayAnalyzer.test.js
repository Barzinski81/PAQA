import { analyzeArray } from '../arrayAnalyzer.js'
import { expect } from 'chai'

describe('Analyze an array', () => {

    it('The input is an array of numbers', () => {

        let expected = {
            min: 1,
            max: 15,
            length: 5
        };

        expect(analyzeArray([1, 7, 8, 15, 9]).min).to.equal(expected.min);
        expect(analyzeArray([1, 7, 8, 15, 9]).max).to.equal(expected.max);
        expect(analyzeArray([1, 7, 8, 15, 9]).length).to.equal(expected.length);
              
    });

    it('The input is an empty array', () => {
      
        expect(analyzeArray([])).to.be.undefined;
                      
    });

    it('The input is a non-array input', () => {
      
        expect(analyzeArray('text')).to.be.undefined;
                      
    });
    
    it('The input is a single element array', () => {

        let expected = {
            min: 7,
            max: 7,
            length: 1
        };

        expect(analyzeArray([7]).min).to.equal(expected.min);
        expect(analyzeArray([7]).max).to.equal(expected.max);
        expect(analyzeArray([7]).length).to.equal(expected.length);
    });

    it('The input is an array with equal elements', () => {

        let expected = {
            min: 7,
            max: 7,
            length: 4
        };

        expect(analyzeArray([7, 7, 7, 7]).min).to.equal(expected.min);
        expect(analyzeArray([7, 7, 7, 7]).max).to.equal(expected.max);
        expect(analyzeArray([7, 7, 7, 7]).length).to.equal(expected.length);
    });
});
