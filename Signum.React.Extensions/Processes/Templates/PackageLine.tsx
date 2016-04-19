﻿import * as React from 'react'
import { classes } from '../../../../Framework/Signum.React/Scripts/Globals'
import { FormGroup, FormControlStatic, EntityComponent, ValueLine, ValueLineType, EntityLine, EntityCombo, EntityList, EntityRepeater, EntityFrame} from '../../../../Framework/Signum.React/Scripts/Lines'
import {SearchControl }  from '../../../../Framework/Signum.React/Scripts/Search'
import { TypeContext, FormGroupStyle } from '../../../../Framework/Signum.React/Scripts/TypeContext'
import { PackageLineEntity, ProcessExceptionLineEntity } from '../Signum.Entities.Processes'

export default class Package extends EntityComponent<PackageLineEntity> {

    renderEntity() {
        
        var e = this.props.ctx.subCtx({readOnly: true});

        return (
            <div>    
                <EntityLine ctx={e.subCtx(f => f.package)}  />
                <EntityLine ctx={e.subCtx(f => f.target)}  />
                <EntityLine ctx={e.subCtx(f => f.result)}  />
                <ValueLine ctx={e.subCtx(f => f.finishTime)}  />
                <fieldset>
                    <legend>{ PackageLineEntity.nicePluralName() }</legend>
                    <SearchControl findOptions={{ queryName: ProcessExceptionLineEntity, parentColumn: "Line", parentValue : e.value}}  />
                </fieldset>
            </div>
        );
    }
}

