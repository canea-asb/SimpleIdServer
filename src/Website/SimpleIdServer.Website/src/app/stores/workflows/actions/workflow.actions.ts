import { createAction, props } from '@ngrx/store';
import { SearchWorkflowFileResult } from '../models/searchworkflowfile.model';
import { SearchWorkflowInstanceResult } from '../models/searchworkflowinstance.model';
import { WorkflowFile } from '../models/workflowfile.model';

export const startSearchFiles = createAction('[Workflows] START_SEARCH_FILES', props<{ startIndex: number, count: number, order: string, direction: string, takeLatest: boolean, fileId: string }>());
export const completeSearchFiles = createAction('[Workflows] COMPLETE_SEARCH_FILES', props<{ content: SearchWorkflowFileResult }>());
export const errorSearchFiles = createAction('[Workflows] ERROR_SEARCH_FILES');
export const startGetFile = createAction('[Workflows] START_GET_FILE', props<{ id: string }>());
export const completeGetFile = createAction('[Workflows] COMPLETE_GET_FILE', props<{ content: WorkflowFile }>());
export const errorGetFile = createAction('[Workflows] ERROR_GET_FILE');
export const startUpdateFile = createAction('[Workflows] START_UPDATE_FILE', props<{ id: string, name: string, description: string }>());
export const completeUpdateFile = createAction('[Workflows] COMPLETE_UPDATE_FILE', props<{name: string, description: string}>());
export const errorUpdateFile = createAction('[Workflows] ERROR_UPDATE_FILE');
export const startUpdateFilePayload = createAction('[Workflows] START_UPDATE_FILE_PAYLOAD', props<{ id: string, payload: string }>());
export const completeUpdateFilePayload = createAction('[Workflows] COMPLETE_UPDATE_FILE_PAYLOAD');
export const errorUpdateFilePayload = createAction('[Workflows] ERROR_UPDATE_FILE_PAYLOAD');
export const startPublishFile = createAction('[Workflows] START_PUBLISH_FILE', props<{ id: string }>());
export const completePublishFile = createAction('[Workflows] COMPLETE_PUBLISH_FILE', props<{ id: string }>());
export const errorPublishFile = createAction('[Workflows] ERROR_PUBLISH_FILE');
export const startSearchInstances = createAction('[Workflows] START_SEARCH_INSTANCES', props<{ startIndex: number, count: number, order: string, direction: string, processFileId: string }>());
export const completeSearchInstances = createAction('[Workflows] COMPLETE_SEARCH_INSTANCES', props<{ content: SearchWorkflowInstanceResult }>());
export const errorSearchInstances = createAction('[Workflows] ERROR_SEARCH_INSTANCES');
export const startCreateInstance = createAction('[Workflows] START_CREATE_INSTANCE', props<{ id: string }>());
export const completeCreateInstance = createAction('[Workflows] COMPLETE_CREATE_INSTANCE', props<{ content: SearchWorkflowInstanceResult }>());
export const errorCreateInstance = createAction('[Workflows] ERROR_CREATE_INSTANCE');
export const startInstance = createAction('[Workflows] START_INSTANCE', props<{ id: string }>());
export const completeStartInstance = createAction('[Workflows] COMPLETE_START_INSTANCE');
export const errorStartInstance = createAction('[Workflows] ERROR_START_INSTANCE');
