import {workforceManagement} from '../workforceManagement.js'
import {expect} from 'chai'

describe('Test_workforceManagement', () => {

    describe('Test recruitStaff', () => { 

        it('Valid input', () => {

            expect(workforceManagement.recruitStaff('Dimitrov', 'Developer', 0))
            .to.equal('Dimitrov is not suitable for this role.');
            expect(workforceManagement.recruitStaff('Ivanov', 'Developer', 4))
            .to.equal('Ivanov has been successfully recruited for the role of Developer.');
            expect(() => workforceManagement.recruitStaff('Petkov', 'QA', 2))
            .to.throw('We are not currently hiring for this role.');

        });

    });

    describe('Test computeWages', () => { 

        it('Valid input', () => {

            expect(workforceManagement.computeWages(120)).to.equal(2160);
            expect(workforceManagement.computeWages(180)).to.equal(4740);

        });

        it('Invalid input', () => {

            expect(() => workforceManagement.computeWages(-120)).to.throw('Invalid hours');            
            expect(() => workforceManagement.computeWages('abc')).to.throw('Invalid hours');

        });

    });

    describe('Test dismissEmployee', () => { 

        it('Valid input', () => {

            expect(workforceManagement.dismissEmployee(['Ivan', 'Jordan'], 1)).to.equal('Ivan');
            expect(workforceManagement.dismissEmployee(['Ivan', 'Vasil', 'Jordan'], 1)).to.equal('Ivan, Jordan');

        });

        it('Invalid input', () => {

            expect(() => workforceManagement.dismissEmployee(['Ivan', 'Vasil'], 3)).to.throw('Invalid input');
            expect(() => workforceManagement.dismissEmployee(['Ivan', 'Vasil'], -1)).to.throw('Invalid input');
            expect(() => workforceManagement.dismissEmployee(['Ivan', 'Vasil'], 5.5)).to.throw('Invalid input');
            expect(() => workforceManagement.dismissEmployee({}, 1)).to.throw('Invalid input');
            expect(() => workforceManagement.dismissEmployee(null, 1)).to.throw('Invalid input');
            expect(() => workforceManagement.dismissEmployee()).to.throw('Invalid input');
            
        });
     
    });

});